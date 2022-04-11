using AutoMapper;
using Contracts;
using Entities.DTO.NhanVien;
using Entities.Models;
using QuanLyThuVien.Services.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly IRepositoryManager _repository;
        private ILoggerManager _logger;
        private readonly IMapper _mapper;
        public NhanVienService(IRepositoryManager repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<NhanVien> CreateNhanVienAsync(NhanVienForCreationDto nhanvien)
        {
            var nv = _mapper.Map<NhanVien>(nhanvien);
            _repository.NhanVien.CreateNhanVien(nv);
            await _repository.SaveAsync();
            var result = await GetNhanVienByIdAsync(nv.Id);
            return result;
        }


        public async Task<IEnumerable<NhanVien>> GetAllNhanVienAsync(NhanVienParameters nhanvienParameters)
        {
            return await _repository.NhanVien.GetAllNhanVienAsync(nhanvienParameters);
        }

        public async Task<NhanVien> GetNhanVienByIdAsync(Guid id)
        {
            return await _repository.NhanVien.GetNhanVienByIdAsync(id);
        }

        public void DeleteNhanVienAsync(NhanVien nhanvien)
        {
            _repository.NhanVien.DeleteNhanVien(nhanvien);
        }

        public async Task<NhanVien> UpdateNhanVienAsync(NhanVien nhanvien)
        {
            
            _repository.NhanVien.UpdateNhanVien(nhanvien);
            await _repository.SaveAsync();
            var result = await GetNhanVienByIdAsync(nhanvien.Id);
            return result;
        }

        public async Task<int> GetCountNhanVien()
        {
            return await _repository.NhanVien.CountNhanVien();
        }
    }
}