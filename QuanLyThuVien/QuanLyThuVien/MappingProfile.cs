using AutoMapper;
using Entities.DTO.DocGia;
using Entities.DTO.NhanVien;
using Entities.DTO.PhieuMuon;
using Entities.DTO.Sach;
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
            CreateMap<SachForCreationDto, Sach>();
            CreateMap<NhanVienForUpdateDto, NhanVien>();
            CreateMap<DocGiaForCreationUpdateDto, DocGia>();
            CreateMap<PhieuMuonForCreationDto, PhieuMuon>();
            CreateMap<CTPhieuMuonForCreationDto, ChiTietPhieuMuon>();
            CreateMap<SachMuonForCreationDto, ChiTietPhieuMuon>();
            CreateMap<UserForCreate, User>();
            CreateMap<User, UserForView>()
                .ForMember(x => x.BoPhan, opt => opt.MapFrom(x => x.NhanVien.BoPhan))
                .ForMember(x => x.TenNhanVien, opt => opt.MapFrom(x => x.NhanVien.HoTen));
        }
    }
}
