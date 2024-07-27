using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class NhanVien
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        // Navigation
        public virtual List<HoaDon>? HoaDons { get; set; }
    }
}
