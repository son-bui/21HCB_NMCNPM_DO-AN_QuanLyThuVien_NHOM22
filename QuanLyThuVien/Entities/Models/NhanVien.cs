using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class NhanVien
    {
        [Column("NhanVienId")]
        [Required(ErrorMessage = "Tên nhân viên không được bỏ trống.")]
        [MaxLength(60, ErrorMessage = "Tối đa 60 kí tự.")]
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string BangCap { get; set; }
        public string BoPhan { get; set; }
        public string ChucVu { get; set; }
    }
}
