using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CurrentProccessContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CurrentProccessDb;Trusted_Connection=true");
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<CurrentCode> CurrentCodes { get; set; }
        public DbSet<CurrentGroupCode> CurrentGroupCodes { get; set; }
        public DbSet<Debt> Debts { get; set; }
    }
}
