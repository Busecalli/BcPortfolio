using EntityLayer.Concrete;
using EntityLayer.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BUSE;database=BcPortfolio;integrated security=true");
        }
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Hakkimda> Hakkimda { get; set; }
        public DbSet<Servis> Servisler { get; set; }
        public DbSet<Tecrube> Tecrubeler { get; set; }
        public DbSet<Yetenek> Yetenekler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
    }
}
