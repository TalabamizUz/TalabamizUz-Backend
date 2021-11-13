using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Core.Interfaces.User;
using TalabamizUz.Data.Contexts;
using TalabamizUz.Domain.Models.User;

namespace TalabamizUz.Core.Services.User
{
    public class UserService : IUserService
    {
        private readonly TalabamizDbContext _dbContext;
        public UserService(TalabamizDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Account> CreateUser(Account account)
        {
            var user = await _dbContext.Accounts.FirstOrDefaultAsync(p => p.Phone == account.Phone && p.Password == account.Password);
            if (user is null)
            {
                var entry = _dbContext.Accounts.Add(account);

                await _dbContext.SaveChangesAsync();
                return entry.Entity;
            }
            return null;
        }

        public async Task DeleteUser(int userId)
        {
            var user = await _dbContext.Accounts.FirstOrDefaultAsync(p => p.Id == userId);

            if (user is not null)
            {
                _dbContext.Accounts.Remove(user);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Account>> GetUser()
        {
            var users = await _dbContext.Accounts.ToListAsync();
            return users;
        }

        public async Task<Account> GetUser(int userId)
        {
            var user = await _dbContext.Accounts.FirstOrDefaultAsync(p => p.Id == userId);
            return user;
        }

        public async Task<Account> SignIn(string phone, string password)
        {
            var user = await _dbContext.Accounts.
                FirstOrDefaultAsync(p => p.Phone == phone && p.Password == password);

            return user;
        }

        public async Task<Account> UpdateUser(int userId, Account account)
        {
            var user = await _dbContext.Accounts.FirstOrDefaultAsync(p => p.Id == userId);
            if(user != null)
            {
                user.Firstname = account.Firstname;
                user.Lastname = account.Lastname;
                user.Phone = account.Phone;
                user.Password = account.Password;
            }

            await _dbContext.SaveChangesAsync();
            return user;
        }
    }
}
