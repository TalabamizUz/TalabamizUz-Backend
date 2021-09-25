using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Models.Account;

namespace TalabamizUz.Data.Contexts
{
    public class TalabamizDbContext : DbContext
    {
        public TalabamizDbContext(DbContextOptions<TalabamizDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
