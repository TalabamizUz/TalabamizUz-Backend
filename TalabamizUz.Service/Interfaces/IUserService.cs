using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Models.Account;

namespace TalabamizUz.Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> CreateUserAsync(User user);
        Task<bool> DeleteUserAsync(Guid Id);
        Task<User> LoginAsync(string login, string password);
        Task<User> UpdateUserAsync(Guid Id, User user);
    }
}
