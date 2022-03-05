using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private INhanVienRepository _nhanvienRepository;
        private IDocGiaRepository _docgiaRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public INhanVienRepository NhanVien
        {
            get
            {
                if (_nhanvienRepository == null)
                    _nhanvienRepository = new NhanVienRepository(_repositoryContext);
                return _nhanvienRepository;
            }
        }
        public IDocGiaRepository DocGia
        {
            get
            {
                if (_docgiaRepository == null)
                    _docgiaRepository = new DocGiaRepository(_repositoryContext);
                return _docgiaRepository;
            }
        }
        public void Save() => _repositoryContext.SaveChanges();

    }
}
