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
        public bool CreateHDCT(int soluong, int maSP, int MaHD, int Gia)
        {

            Hdct hdct = new Hdct()
            {
                Gia = Gia,
                Soluong = soluong,
                Idsp = maSP,
                Idhd = MaHD
            };
            try
            {
                _dbFirstContext.Hdcts.Add(hdct); _dbFirstContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
