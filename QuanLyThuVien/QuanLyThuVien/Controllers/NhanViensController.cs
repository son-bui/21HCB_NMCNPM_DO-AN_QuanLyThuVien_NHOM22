using AutoMapper;
using Contracts;
using Entities.DTO;
using Entities.DTO.NhanVien;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Controllers
{
    [Route("api/nhanviens")]
    [ApiController]
    public class NhanViensController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly INhanVienService _nhanvienService;
        private readonly IMapper _mapper;
        private ILoggerManager _logger;
        public NhanViensController(IRepositoryManager repository, IMapper mapper, ILoggerManager logger, INhanVienService nhanvienService)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
            _nhanvienService = nhanvienService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllNhanVien([FromQuery] NhanVienParameters nhanvienParameters)
        {
            var nvs = await _nhanvienService.GetAllNhanVienAsync(nhanvienParameters);
            return Ok(nvs);
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetNhanVienById(Guid id)
        {
            var nv = await _nhanvienService.GetNhanVienByIdAsync(id);
            if (nv == null)
            {
                _logger.LogInfo($"Nhân viên với id: {id} không tồn tại .");
                return NotFound();
            }
            return Ok(nv);

        }
        [HttpPost("CreateNhanVien")]
        public async Task<IActionResult> CreateNhanVien(NhanVienForCreationDto nhanvien)
        {
            return Ok(await _nhanvienService.CreateNhanVienAsync(nhanvien));
        }
        [HttpPut("UpdateNhanVien/{id}")]
        public async Task<IActionResult> UpdateNhanVien(Guid id, NhanVienForUpdateDto nhanvien)
        {
            var nv = await _repository.NhanVien.GetNhanVienByIdAsync(id);
            if (nv == null)
            {
                _logger.LogInfo($"Nhân viên với id: {id} không tồn tại .");
                return NotFound();
            }
            
            return Ok(await _nhanvienService.UpdateNhanVienAsync(nhanvien));
        }
        [HttpDelete("DeleteNhanVien/{id}")]
        public async Task<IActionResult> DeleteNhanVienById(Guid id)
        {
            var nv = await _repository.NhanVien.GetNhanVienByIdAsync(id);
            if (nv == null)
            {
                _logger.LogInfo($"Nhân viên với id: {id} không tồn tại .");
                return NotFound();
            }
            _nhanvienService.DeleteNhanVienAsync(nv);
            await _repository.SaveAsync();
            return NoContent();
        }
    }
}
