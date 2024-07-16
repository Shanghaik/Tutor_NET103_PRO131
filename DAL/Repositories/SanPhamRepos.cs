using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SanPhamRepos
    {
        Demo_DBFirstContext _context = new Demo_DBFirstContext(); // Đê đỡ quên có thể tạo luôn
        public SanPhamRepos()
        {
            _context = new Demo_DBFirstContext(); // Khởi tạo => ưu tiên
        }
        public List<SanPham> GetAll()
        {
            return _context.SanPhams.ToList(); // Lấy ra danh sách toàn bộ sản phẩm
        }
        public SanPham GetById(int id)
        {
            return _context.SanPhams.Find(id); // Phương thức Find(id) chỉ áp dụng khi id là khóa chính
        }
        public bool CreateSP(SanPham sp)
        {
            try
            {
                _context.SanPhams.Add(sp); _context.SaveChanges(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
