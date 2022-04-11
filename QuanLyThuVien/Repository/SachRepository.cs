using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SachRepository : RepositoryBase<Sach>, ISachRepository
    {
        public SachRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<int> CountSach()
        {
            return await CountAll();
        }

        public void CreateSach(Sach sach)
        {
            Create(sach);
        }

        public void DeleteSach(Sach sach)
        {
            Delete(sach);
        }

        public async Task<IEnumerable<Sach>> GetAllSachAsync(SachParameters sachParameters)
        {
            List<Sach> sachs;
            if (sachParameters.Search == null || sachParameters.Search == "null")
            {
                sachs = await FindAll().OrderBy(e => e.Ten)
                .Skip((sachParameters.PageNumber - 1) * sachParameters.PageSize)
                .Take(sachParameters.PageSize)
                .ToListAsync();
            }
            else
            {
                sachs = await FindByCondition(x => x.Ten.Contains(sachParameters.Search)).OrderBy(e => e.Ten)
                .Skip((sachParameters.PageNumber - 1) * sachParameters.PageSize)
                .Take(sachParameters.PageSize)
                .ToListAsync();
            }
            return sachs;
        }

        public async Task<Sach> GetSachByIdAsync(Guid id)
        {
            var sach = await FindByCondition(x => x.Id.Equals(id)).SingleOrDefaultAsync();
            return sach;
        }

        public void UpdateSach(Sach sach)
        {
            Update(sach);
        }
    }
}
