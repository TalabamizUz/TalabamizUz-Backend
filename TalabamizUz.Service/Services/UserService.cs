using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Core.Interfaces;
using TalabamizUz.Data.Contexts;
using TalabamizUz.Domain.Models.Account;

namespace TalabamizUz.Core.Services
{
    public class UserService : IUserService
    {
        private readonly TalabamizDbContext _dbContext;
        public UserService(TalabamizDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<User> CreateUserAsync(User user)
        {
            var entry = await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            
            return entry.Entity;
        }

        public async Task<bool> DeleteUserAsync(Guid Id)
        {
            var entity = _dbContext.Users.FirstOrDefault(p => p.Id == Id);
            if (entity is null)
                return false;

            _dbContext.Users.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var entities = _dbContext.Users;
            return entities;
        }

        public async Task<User> LoginAsync(string login, string password)
        {
            var entity = await _dbContext.Users.FirstOrDefaultAsync(p => p.Username == login && p.Password == password);
            return entity;
        }

        public async Task<User> UpdateUserAsync(Guid Id, User user)
        {
            var entity = await _dbContext.Users.FirstOrDefaultAsync(p => p.Id == Id);
            if(entity is not null)
            {
                entity.FirstName = user.FirstName;
                entity.LastName = user.LastName;
                entity.Username = user.Username;
                entity.Password = user.Password;
                entity.PhoneNumber = user.PhoneNumber;
                entity.Role = user.Role;
                entity.Address = user.Address;
                
                await _dbContext.SaveChangesAsync();
                return entity;
            }

            return null;
        }
    }
}
