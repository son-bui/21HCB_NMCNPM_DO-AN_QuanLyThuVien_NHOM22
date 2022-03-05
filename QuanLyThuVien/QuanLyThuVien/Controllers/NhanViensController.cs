using AutoMapper;
using Contracts;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IMapper _mapper;
        public NhanViensController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetNhanViens()
        {
            //throw new Exception("Exception");

            var nvs = _repository.NhanVien.GetAllNhanViens(trackChanges: false);
            var nhanvienDto = _mapper.Map<IEnumerable<NhanVienDto>>(nvs);
            return Ok(nhanvienDto);
        }

    }
}
