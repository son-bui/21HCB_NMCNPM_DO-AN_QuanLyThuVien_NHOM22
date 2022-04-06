using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.DocGia
{
    public class DocGiaDto
    {
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public string Loai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public DateTime NgayLap { get; set; }
        public float TongNo { get; set; }
        public Guid NhanVienId { get; set; }
        public string TenNhanVienLap { get; set; }
    }
}
