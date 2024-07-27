using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime TGTao { get; set; }
        [ForeignKey(nameof(NhanVien))]
        public Guid IdNhanVien { get; set; }
        [ForeignKey(nameof(KhachHang))]
        public string IdKhach { get; set; }
        public virtual ICollection<Hdct> Hdcts { get; set; }
        // Navi
        public virtual NhanVien NhanVien { get; set; }  
        public virtual KhachHang KhachHang { get; set;}
    }
}
