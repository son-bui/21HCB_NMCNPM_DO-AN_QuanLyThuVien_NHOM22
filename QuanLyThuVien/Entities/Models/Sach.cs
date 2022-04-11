using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Sach
    {
        [Column("SachId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Tên sách không được bỏ trống.")]
        [MaxLength(60, ErrorMessage = "Tối đa 60 kí tự.")]
        public string Ten { get; set; }
        public string Loai { get; set; }
        public string TacGia { get; set; }
        public string NamSx { get; set; }
        public string NhaSx { get; set; }
        public string TinhTrang { get; set; }
        public float Gia { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        [ForeignKey(nameof(NhanVien))]
        public Guid NhanVienId { get; set; }
    }
}
