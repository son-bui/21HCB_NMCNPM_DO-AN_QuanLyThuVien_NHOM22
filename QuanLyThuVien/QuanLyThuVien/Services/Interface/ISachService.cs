using Entities.DTO.Sach;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services.Interface
{
    public interface ISachService
    {
        public Task<Sach> CreateSachAsync(SachForCreationDto Sach);
        public Task<IEnumerable<Sach>> GetAllSachAsync(SachParameters SachParameters);
        public Task<Sach> GetSachByIdAsync(Guid id);
        public void DeleteSachAsync(Sach Sach);
        public Task<int> GetCountSach();
        public Task<Sach> UpdateSachAsync(Sach Sach);
    }
}
