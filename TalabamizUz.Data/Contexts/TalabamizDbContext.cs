using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Models.Flat;
using TalabamizUz.Domain.Models.User;

namespace TalabamizUz.Data.Contexts
{
    public class TalabamizDbContext : DbContext
    {
        public TalabamizDbContext(DbContextOptions<TalabamizDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountDetail> AccountDetails { get; set; }
        public DbSet<FlatModel> Flats { get; set; }
    }
}
