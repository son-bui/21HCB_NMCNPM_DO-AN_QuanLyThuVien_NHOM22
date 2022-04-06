using AutoMapper;
using Contracts;
using Entities.DTO.User;
using Entities.Models;
using QuanLyThuVien.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyThuVien.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepositoryManager _repository;
        private ILoggerManager _logger;
        private readonly IMapper _mapper;
        public AuthService(IRepositoryManager repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<User> GetUser(string email)
        {
            return await _repository.User.GetUser(email);

        }

        public async Task<User> IsLoginValid(LoginDTO loginDTO)
        {
            var user = await _repository.User.GetUser(loginDTO.Email);
            if (user == null || !Hash.Validate(loginDTO.Password, user.PasswordSalt, user.PasswordHash))
                return null;
            return user;
        }

        public async Task<EnumStatusCode> Register(UserForCreate userForCreate)
        {
            //check email exist
            if (await _repository.User.IsEmailExist(userForCreate.Email))
                return EnumStatusCode.EmailExist;

            //map user get from register form to user and setup password hash, password salt
            var user = _mapper.Map<User>(userForCreate);
            user.PasswordSalt = Salt.Create();
            user.PasswordHash = Hash.Create(userForCreate.Password, user.PasswordSalt);

            _repository.User.CreateUser(user);
            await _repository.SaveAsync();

            return EnumStatusCode.OK;
        }

        public async Task UpdateUser(User user)
        {
            _repository.User.UpdateUser(user);
            await _repository.SaveAsync();
        }
    }
}
