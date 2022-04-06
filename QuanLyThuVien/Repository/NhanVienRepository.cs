using Contracts;
using Entities;
using Entities.DTO.NhanVien;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NhanVienRepository : RepositoryBase<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateNhanVien(NhanVien nhanvien)
        {
            Create(nhanvien);
        }

        public void DeleteNhanVien(NhanVien nhanvien)
        {
            Delete(nhanvien);

        }
        public void UpdateNhanVien(NhanVien nhanvien)
        {
            Update(nhanvien);
        }

        public async Task<IEnumerable<NhanVien>> GetAllNhanVienAsync(NhanVienParameters nhanvienParameters)
        {
            List<NhanVien> nhanviens;

            nhanviens = await FindAll().OrderBy(e => e.HoTen)
            .Skip((nhanvienParameters.PageNumber - 1) * nhanvienParameters.PageSize)
            .Take(nhanvienParameters.PageSize)
            .ToListAsync();

            return nhanviens;
        }

        public async Task<NhanVien> GetNhanVienByIdAsync(Guid id)
        {
            var nv = await FindByCondition(x => x.Id.Equals(id)).SingleOrDefaultAsync();
            return nv;
        }


    }
}
