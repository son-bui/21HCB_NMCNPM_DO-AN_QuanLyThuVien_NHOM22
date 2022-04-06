using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.NhanVien
{
    public class NhanVienForUpdateDto
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string BangCap { get; set; }
        public string BoPhan { get; set; }
        public string ChucVu { get; set; }
    }
}
