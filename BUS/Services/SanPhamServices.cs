﻿using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamServices
    {
        SanPhamRepos _repo = new SanPhamRepos(); // 1 là cái này
        public SanPhamServices()
        {
            _repo = new SanPhamRepos(); // 2 là cái này chọn 1 trong 2 cách thôi
        }
        public List<SanPham> GetAll()
        {
            return _repo.GetAll();
        }
    }
}