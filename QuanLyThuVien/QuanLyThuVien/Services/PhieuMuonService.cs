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
    public class PhieuMuonService: IPhieuMuonService
    {
        private readonly IRepositoryManager _repository;
        private ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly ICTPhieuMuonService _ctpmService;
        public PhieuMuonService(IRepositoryManager repository, IMapper mapper, ILoggerManager logger, ICTPhieuMuonService ctpmService)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
            _ctpmService = ctpmService;

        }

        public async Task<PhieuMuon> CreatePhieuMuonAsync(PhieuMuonForCreationDto pm)
        {
            var phieumuon = _mapper.Map<PhieuMuon>(pm);
            _repository.PhieuMuon.CreatePhieuMuon(phieumuon);
            await _repository.SaveAsync();
            if (pm.SachMuons != null)
            {
                foreach(var ctpm in pm.SachMuons)
                {
                    await _ctpmService.CreateCtPmAsync(ctpm, phieumuon.Id);
                }
            }
            var result = await GetPhieuMuonByIdAsync(phieumuon.Id);

            return result;
        }

        public async Task<PhieuMuon> GetPhieuMuonByIdAsync(Guid id)
        {
            var pm = await _repository.PhieuMuon.GetPhieuMuonByIdAsync(id);
            pm.DocGia = await _repository.DocGia.GetDocGiaByIdAsync(pm.DocGiaId);
            pm.CTPhieuMuons = await _ctpmService.GetAllCTPhieuMuonByPmId(pm.Id);
            return pm;
        }

    }
}
