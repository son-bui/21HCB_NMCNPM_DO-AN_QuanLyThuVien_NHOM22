using Entities.DTO.NhanVien;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services.Interface
{
    public interface INhanVienService
    {
        public Task<NhanVien> CreateNhanVienAsync(NhanVienForCreationDto nhanvien);
        public Task<IEnumerable<NhanVien>> GetAllNhanVienAsync(NhanVienParameters nhanvienParameters);
        public Task<NhanVien> GetNhanVienByIdAsync(Guid id);
        public void DeleteNhanVienAsync(NhanVien nhanvien);
        public Task<int> GetCountNhanVien();
        public Task<NhanVien> UpdateNhanVienAsync(NhanVien nhanvien);
    }
}
