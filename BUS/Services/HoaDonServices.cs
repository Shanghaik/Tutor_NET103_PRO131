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
    }
}
