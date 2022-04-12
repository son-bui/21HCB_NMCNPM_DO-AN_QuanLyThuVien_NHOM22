using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPhieuMuonRepository
    {
        Task<IEnumerable<PhieuMuon>> GetAllPhieuMuonAsync(PhieuMuonParameters pmParameters);
        Task<PhieuMuon> GetPhieuMuonByIdAsync(Guid id);
        Task<int> CountPhieuMuon();
        void CreatePhieuMuon(PhieuMuon pm);
        void UpdatePhieuMuon(PhieuMuon pm);
        void DeletePhieuMuon(PhieuMuon pm);
    }
}
