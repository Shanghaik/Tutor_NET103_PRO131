using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            Hdcts = new HashSet<Hdct>();
        }

        public int Id { get; set; }
        public decimal? TongTien { get; set; }
        public string? Mota { get; set; }
        public int? Trangthai { get; set; }

        public virtual ICollection<Hdct> Hdcts { get; set; }
    }
}
