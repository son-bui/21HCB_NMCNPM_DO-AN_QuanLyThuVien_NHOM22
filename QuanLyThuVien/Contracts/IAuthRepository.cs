using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAuthRepository
    {
        Task<bool> IsEmailExist(string email);
        Task<User> GetUser(string email);
        void CreateUser(User user);
        void UpdateUser(User user);
    }
}
