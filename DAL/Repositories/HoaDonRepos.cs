using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonRepos
    {
        Demo_DBFirstContext context = new Demo_DBFirstContext();
        public HoaDonRepos() { }
        public List<HoaDon> GetAll()
        {
            return context.HoaDons.ToList();
        }
        public bool Create(HoaDon hoaDon)
        {
            try
            {
                context.HoaDons.Add(hoaDon); 
                context.SaveChanges();
                return true;    
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateHD(int id, int status)
        {
            try
            {
                var hd = context.HoaDons.Find(id);
                hd.Trangthai = status;
                context.SaveChanges();
                return true;    
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteHD(int idhd) // Xóa kèm cả những HDCT của nó nếu không sẽ không thể xóa được
        {
            try
            {
                var allHDCT = context.Hdcts.Where(p => p.Idhd == idhd); //Lấy ra tất cả HDCT cần xóa kèm
                context.Hdcts.RemoveRange(allHDCT); // xóa cả 1 lô 1 lốc đi
                context.SaveChanges();
                // Bây giờ xong mới đi xóa hóa đơn
                var hd = context.HoaDons.Find(idhd);
                context.HoaDons.Remove(hd);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
