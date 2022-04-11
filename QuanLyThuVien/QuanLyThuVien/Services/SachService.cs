using AutoMapper;
using Contracts;
using Entities.DTO.Sach;
using Entities.Models;
using QuanLyThuVien.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services
{
    public class SachService : ISachService
    {
        private readonly IRepositoryManager _repository;
        private ILoggerManager _logger;
        private readonly IMapper _mapper;
        public SachService(IRepositoryManager repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Sach> CreateSachAsync(SachForCreationDto Sach)
        {
            var sach = _mapper.Map<Sach>(Sach);
            sach.NgayTiepNhan = DateTime.Now;
            _repository.Sach.CreateSach(sach);
            await _repository.SaveAsync();
            var result = await GetSachByIdAsync(sach.Id);
            return result;

        }

        public async Task<IEnumerable<Sach>> GetAllSachAsync(SachParameters SachParameters)
        {
            return await _repository.Sach.GetAllSachAsync(SachParameters);
        }

        public async Task<Sach> GetSachByIdAsync(Guid id)
        {
            return await _repository.Sach.GetSachByIdAsync(id);
        }

        public void DeleteSachAsync(Sach Sach)
        {
            _repository.Sach.DeleteSach(Sach);
        }

        public async Task<int> GetCountSach()
        {
            return await _repository.Sach.CountSach();
        }

        public async Task<Sach> UpdateSachAsync(Sach Sach)
        {
            _repository.Sach.UpdateSach(Sach);
            await _repository.SaveAsync();
            var result = await GetSachByIdAsync(Sach.Id);
            return result;
        }
    }
}
