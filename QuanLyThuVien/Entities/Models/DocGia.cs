using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DocGia
    {
        [Column("DocGiaId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Tên độc giả không được bỏ trống.")]
        [MaxLength(60, ErrorMessage = "Tối đa 60 kí tự.")]
        public string HoTen { get; set; }
        public string Loai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public DateTime NgayLap { get; set; }
        public float TongNo { get; set; }
        [ForeignKey(nameof(NhanVien))]
        public Guid NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
