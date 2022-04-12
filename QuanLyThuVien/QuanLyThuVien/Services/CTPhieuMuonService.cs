using AutoMapper;
using Contracts;
using Entities.DTO.PhieuMuon;
using Entities.Models;
using QuanLyThuVien.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services
{
    public class CTPhieuMuonService : ICTPhieuMuonService
    {
        private readonly IRepositoryManager _repository;
        private ILoggerManager _logger;
        private readonly IMapper _mapper;
        
        public CTPhieuMuonService(IRepositoryManager repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task CreateCTPhieuMuonAsync(CTPhieuMuonForCreationDto ctpm)
        {
            var chitietpm = _mapper.Map<ChiTietPhieuMuon>(ctpm);
            _repository.CTPhieuMuon.CreateCTPhieuMuon(chitietpm);
            await _repository.SaveAsync();
        }

        public async Task CreateCtPmAsync(SachMuonForCreationDto ctpm, Guid pmId)
        {
            var chitietpm = _mapper.Map<ChiTietPhieuMuon>(ctpm);
            chitietpm.PhieuMuonId = pmId;
            _repository.CTPhieuMuon.CreateCTPhieuMuon(chitietpm);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ChiTietPhieuMuon>> GetAllCTPhieuMuonByPmId(Guid pmId)
        {
            var listCtpm = await _repository.CTPhieuMuon.GetAllCTPhieuMuonByIdPmAsync(pmId);
            if(listCtpm != null)
            {
                foreach(var ctpm in listCtpm)
                {
                    ctpm.Sach = await _repository.Sach.GetSachByIdAsync(ctpm.SachId);
                }
            }
            return listCtpm;
        }
    }
}
