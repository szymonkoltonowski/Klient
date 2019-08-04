using Klient.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klient.Model.Configuration
{
    public class AdresEntityConfiguration : IEntityTypeConfiguration<AdresEntity>
    {
        public void Configure(EntityTypeBuilder<AdresEntity> builder)
        {
            builder.HasKey(adres => adres.Id);
        }

    }
}
