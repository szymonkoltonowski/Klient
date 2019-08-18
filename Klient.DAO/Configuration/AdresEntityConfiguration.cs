using Klient.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klient.Application.Configuration
{
    public class AdresEntityConfiguration : IEntityTypeConfiguration<AdresEntity>
    {
        public void Configure(EntityTypeBuilder<AdresEntity> builder)
        {
            builder.HasKey(adres => adres.Id);

            builder.Property(adres => adres.Miasto).HasMaxLength(60);
        }

    }
}
