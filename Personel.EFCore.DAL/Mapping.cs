using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personel.EFCore.Domain;
namespace Personel.EFCore.DAL
{
    public class Mapping:IEntityTypeConfiguration<Personel.EFCore.Domain.Personel>
    {
        public void Configure(EntityTypeBuilder<Personel.EFCore.Domain.Personel> builder)
        {
            builder.ToTable("Personel");
            builder.HasKey(x => x.PersonelID);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IdentityNumber).IsRequired().HasMaxLength(12);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Ignore(x => x.IsActive);
            builder.HasOne(p => p.PersonelDetail)
                 .WithOne(pd => pd.Personel)
                 .HasForeignKey<PersonelDetail>(pd => pd.PersonelID);

        }
    }
}
