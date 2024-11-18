using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personel.EFCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.EFCore.DAL
{
    public class Mapping_PD : IEntityTypeConfiguration<PersonelDetail>
    {
        public void Configure(EntityTypeBuilder<PersonelDetail> builder)
        {
            builder.ToTable("PersonelDetail");
            builder.HasKey(x => x.PersonelDetailID);

            builder.Property(x => x.Email).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(500);
        }
    }
}
