using Microsoft.EntityFrameworkCore;
using Klient.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klient.Application.Configuration
{
    public class KlientEntityConfiguration : IEntityTypeConfiguration<KlientEntity>
    {
        public void Configure(EntityTypeBuilder<KlientEntity> builder)
        {
            builder.HasKey(klient => klient.Id);
            builder.Property(k => k.Imie).HasMaxLength(50);
            builder.Property(k => k.Imie).HasMaxLength(50);
            builder.Property(k => k.Pesel).HasMaxLength(11);

        }
    }
}
