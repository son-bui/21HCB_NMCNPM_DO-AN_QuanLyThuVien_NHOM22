using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace QuanLyThuVien.Services.Interface
{
    public interface ITokenService
    {
        public string CreateRefreshToken();
        public string CreateAccessToken(User user);
        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
