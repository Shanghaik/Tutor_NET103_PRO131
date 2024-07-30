using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HDCTRepos
    {
        Demo_DBFirstContext _dbFirstContext;
        public HDCTRepos()
        {
            _dbFirstContext = new Demo_DBFirstContext();
        }
        public List<Hdct> GetAllByHD(int idHD)
        {
            return _dbFirstContext.Hdcts.Where(p => p.Idhd == idHD).ToList();
        }
        public bool CreateHDCT(int soluong, int maSP, int MaHD)
        {
            SanPham sp = _dbFirstContext.SanPhams.Find(maSP); // sửa cái này để không lấy data trên form
            Hdct hdct = new Hdct()
            {
                Gia = sp.Gia,
                Soluong = soluong,
                Idsp = maSP,
                Idhd = MaHD
            };
            try
            {
                _dbFirstContext.Hdcts.Add(hdct); 
                // Trừ số lượng sản phẩm trong DB 
                sp.Soluong = sp.Soluong - soluong;
                _dbFirstContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }
        public bool UpdateSL(int soluong, int idHDCT)
        {
            try
            {
                var hdct = _dbFirstContext.Hdcts.Find(idHDCT); // Lấy cái cần sửa ra
                hdct.Soluong = soluong + hdct.Soluong; // Update số lượng trong HDCT - chưa validate
                // Trừ số lượng sản phẩm trong DB
                var sp = _dbFirstContext.SanPhams.Find(hdct.Idsp);
                sp.Soluong = sp.Soluong - soluong;
                _dbFirstContext.SaveChanges(); return true; // Lưu lại
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(int idHDCT)
        {
            try
            {
                var hdct = _dbFirstContext.Hdcts.Find(idHDCT); // Lấy cái cần xóa ra
                _dbFirstContext.Hdcts.Remove(hdct); // xóa
                _dbFirstContext.SaveChanges(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
