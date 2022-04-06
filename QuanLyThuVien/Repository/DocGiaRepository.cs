using AutoMapper;
using Contracts;
using Entities;
using Entities.DTO.DocGia;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DocGiaRepository : RepositoryBase<DocGia>, IDocGiaRepository
    {
        public DocGiaRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateDocGia(DocGia docgia)
        {
            Create(docgia);
        }

        public void DeleteDocGia(DocGia docgia)
        {
            Delete(docgia);
        }
        public void UpdateDocGia(DocGia docgia)
        {
            Update(docgia);
        }

        public async Task<IEnumerable<DocGia>> GetAllDocGiaAsync(DocGiaParameters nhanvienParameters)
        {
            List<DocGia> docgias;
            docgias = await FindAll().OrderBy(e => e.HoTen)
                .Skip((nhanvienParameters.PageNumber - 1) * nhanvienParameters.PageSize)
                .Take(nhanvienParameters.PageSize)
                .ToListAsync();
            return docgias;
        }

        public async Task<DocGia> GetDocGiaByIdAsync(Guid id)
        {
            var dg = await FindByCondition(x => x.Id.Equals(id)).SingleOrDefaultAsync();
            return dg;
        }
    }
}
