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
    }
}
