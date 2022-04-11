using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ISachRepository
    {
        Task<IEnumerable<Sach>> GetAllSachAsync(SachParameters sachParameters);
        Task<Sach> GetSachByIdAsync(Guid id);
        Task<int> CountSach();
        void CreateSach(Sach sach);
        void UpdateSach(Sach sach);
        void DeleteSach(Sach sach);
    }
}
