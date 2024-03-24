using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Bankomat
{
    public  class BankomatDbContext : DbContext
    {
        private readonly string dbPutanja;

        public BankomatDbContext()
        {
            dbPutanja = ConfigurationManager.ConnectionStrings["Bankomat"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Transakcija> Transakcije { get; set; }
    }
}
