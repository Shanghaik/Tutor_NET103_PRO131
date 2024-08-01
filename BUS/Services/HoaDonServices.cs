using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonServices
    {
        HoaDonRepos repo = new HoaDonRepos();
        public HoaDonServices()
        {
        }
        public List<HoaDon> GetAll()
        {
            return repo.GetAll();
        }
        // Phương thức này để lấy ra tất cả danh sách các hóa đơn chưa thnah toán (có trạng thái là 1)
        public List<HoaDon> GetAllNotPaid()
        {
            return repo.GetAll().Where(p => p.Trangthai == 1).ToList();
        }
        public string Create(Guid idNV, string idKH)
        {
            HoaDon hoadon = new HoaDon()
            {
                IdKhach = idKH,
                IdNhanVien = idNV,
                TGTao = DateTime.Now,
                Mota = "Hettien",
                TongTien = 0,
                Trangthai = 1,
            };
            if (repo.Create(hoadon))
            {
                return "Tạo thành công";
            }
            else return "Mẹ thành công";
        }
        public string Update(int idHD, int trangthai, long? totalMoney)
        {
            if (repo.UpdateHD(idHD, trangthai, totalMoney))
            {
                return "Cập nhật đơn hàng thành công";
            }
            else return "Thất bại";
        }

    }
}
