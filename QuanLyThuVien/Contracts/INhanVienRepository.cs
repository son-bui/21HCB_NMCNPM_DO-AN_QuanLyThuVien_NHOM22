using Entities.DTO.NhanVien;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface INhanVienRepository
    {

        Task<IEnumerable<NhanVien>> GetAllNhanVienAsync(NhanVienParameters nhanvienParameters);
        Task<NhanVien> GetNhanVienByIdAsync(Guid id);

        void CreateNhanVien(NhanVien nhanvien);

        void UpdateNhanVien(NhanVien nhanvien);

        void DeleteNhanVien(NhanVien nhanvien);

    }
}
