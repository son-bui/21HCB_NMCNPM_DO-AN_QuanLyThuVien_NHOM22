using Entities.DTO.PhieuMuon;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services.Interface
{
    public interface IPhieuMuonService
    {
        public Task<PhieuMuon> CreatePhieuMuonAsync(PhieuMuonForCreationDto pm);
        public Task<PhieuMuon> GetPhieuMuonByIdAsync(Guid id);

    }
}
