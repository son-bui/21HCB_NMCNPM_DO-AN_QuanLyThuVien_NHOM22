using Entities.DTO.User;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services.Interface
{
    public interface IAuthService
    {
        public Task<EnumStatusCode> Register(UserForCreate userForCreate);
        public Task<User> IsLoginValid(LoginDTO loginDTO);
        public Task UpdateUser(User user);
        public Task<User> GetUser(string email);
    }
}
