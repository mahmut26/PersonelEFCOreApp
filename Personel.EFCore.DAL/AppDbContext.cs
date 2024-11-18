using Microsoft.EntityFrameworkCore;
//using Personel.EFCore.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personel.EFCore.Domain;

namespace Personel.EFCore.DAL
{

public class AppDbContext : DbContext
    {
        public DbSet<Personel.EFCore.Domain.Personel> Personel { get; set; }
        public DbSet<Personel.EFCore.Domain.PersonelDetail> PersonelDetail { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("Server=DESKTOP-S5AKNFC;Database=rewritten_by_machine_and_new_technology;User Id=sa;Password=2626;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new Mapping().Configure(modelBuilder.Entity <Personel.EFCore.Domain.Personel>());
            new Mapping_PD().Configure(modelBuilder.Entity<PersonelDetail>());
            
        }
    }


}


