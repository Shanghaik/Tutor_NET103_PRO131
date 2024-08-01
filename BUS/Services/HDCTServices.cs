using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HDCTServices
    {
        HDCTRepos repos = new HDCTRepos();
        public HDCTServices()
        {
            repos = new HDCTRepos();
        }
        public List<Hdct> GetAllByHD(int idhd)
        {
            return repos.GetAllByHD(idhd);
        }
        public string Create(int soluong, int maSP, int MaHD)
        {
            if (repos.CreateHDCT(soluong, maSP, MaHD))
            {
                return "Thành công";
            }
            else
            {
                return "Thất bại";
            }
        }
        public string CheckSPinHD(int idsp, int idhd, int soluong) // Kiểm tra xem sản phẩm đã nằm trong hóa đơn chưa?
        {
            var allhdct = repos.GetAllByHD(idhd); // Lấy tất cả HDCT trong hóa đơn đi đã
            var hdct = allhdct.FirstOrDefault(p => p.Idsp == idsp);
            //return hdct != null; // Nếu nó không null nghĩa là tồn tại rồi => true, nếu chưa có sẽ là fail
            if(hdct != null) // tồn tại rồi => Ta đi ta update số lượng sản phẩm trong HDCT
            {
                HDCTRepos repo = new HDCTRepos();
                repo.UpdateSL(soluong, hdct.Id); // Update luôn trên thành phần vừa được lấy ra
                return "thành công";
            }else
            {
                if (repos.CreateHDCT(soluong, idhd, idsp))
                {
                    return "Thành công";
                }
                else
                {
                    return "Thất bại";
                } 
            }
        }
        //Tạo phương thức tính tổng tiền = số sản phẩm trong HDCT * giá của nó (tất cả)
        public long CalculateBill(int idHD)
        {
            List<Hdct> hdcts = repos.GetAllByHD(idHD); // Lấy tất cả HDCT theo ID
            long sum = 0;
            foreach (var item in hdcts)
            {
                sum += (long)item.Gia * (long)item.Soluong;
            }
            return sum;
        }

    }
}
