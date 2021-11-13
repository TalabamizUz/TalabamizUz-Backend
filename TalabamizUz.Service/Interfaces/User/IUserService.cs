using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Models.User;

namespace TalabamizUz.Core.Interfaces.User
{
    public interface IUserService
    {
        Task<Account> CreateUser(Account account);
        Task<Account> UpdateUser(int userId, Account account);
        Task DeleteUser(int userId);
        Task<IEnumerable<Account>> GetUser();
        Task<Account> GetUser(int userId);
        Task<Account> SignIn(string phone, string password);
    }
}
