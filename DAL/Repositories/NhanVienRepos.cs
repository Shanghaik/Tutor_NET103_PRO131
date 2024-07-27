using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanVienRepos
    {
        Demo_DBFirstContext _context = new Demo_DBFirstContext();
        public NhanVienRepos()
        {
            _context = new Demo_DBFirstContext();
        }
        public string CheckLogin(string username, string password)
        {
            try
            {
                var check = _context.NhanViens.SingleOrDefault(p => p.Username == username
                && p.Password == password);
                // First => Lấy phần tử đầu tiên nếu có
                // Single => Lấy phần tử duy nhất
                if (check != null) // Nếu tìm thấy
                {
                    return check.Id.ToString(); // Trả về username của chính người đang đăng nhập
                }
                else return "0";
            }
            catch (Exception e)
            {
                return "1";
            }

        }
    }
}
