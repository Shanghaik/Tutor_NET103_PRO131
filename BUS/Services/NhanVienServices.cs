using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices
    {
        NhanVienRepos repo = new NhanVienRepos();
        public NhanVienServices() { }

        public string Login(string username, string password)
        {
            return repo.CheckLogin(username, password); 
        }
    }
}
