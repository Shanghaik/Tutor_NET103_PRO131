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
        HDCTRepos repos= new HDCTRepos();
        public HDCTServices()
        {

        }
        public List<Hdct> GetAllByHD(int idhd)
        {
            return repos.GetAllByHD(idhd);  
        }
        public string Create(int soluong, int maSP, int MaHD, int Gia)
        {
            if(repos.CreateHDCT(soluong, maSP, MaHD, Gia))
            {
                return "Thành công";
            }else
            {
                return "Thất bại";
            }
        }
    }
}
