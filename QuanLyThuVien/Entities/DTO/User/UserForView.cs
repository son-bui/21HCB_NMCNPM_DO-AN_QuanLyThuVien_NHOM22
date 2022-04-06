using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.User
{
    public class UserForView
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Guid NhanVienId { get; set; }
        public string TenNhanVien { get; set; }
        public string BoPhan { get; set; }
    }
}
