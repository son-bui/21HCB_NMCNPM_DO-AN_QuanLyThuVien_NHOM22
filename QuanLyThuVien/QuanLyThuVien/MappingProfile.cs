using AutoMapper;
using Entities.DTO.DocGia;
using Entities.DTO.NhanVien;
using Entities.DTO.User;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NhanVien, NhanVienDto>();
            CreateMap<DocGia, DocGiaDto>();
            CreateMap<NhanVienForCreationDto, NhanVien>();
            CreateMap<NhanVienForUpdateDto, NhanVien>();
            CreateMap<DocGiaForCreationUpdateDto, DocGia>();
            CreateMap<UserForCreate, User>();
            CreateMap<User, UserForView>()
                .ForMember(x => x.BoPhan, opt => opt.MapFrom(x => x.NhanVien.BoPhan))
                .ForMember(x => x.TenNhanVien, opt => opt.MapFrom(x => x.NhanVien.HoTen));
        }
    }
}
