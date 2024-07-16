using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            Hdcts = new HashSet<Hdct>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public decimal? Gia { get; set; }
        public int? Soluong { get; set; }
        public string? Mota { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<Hdct> Hdcts { get; set; }
    }
}
