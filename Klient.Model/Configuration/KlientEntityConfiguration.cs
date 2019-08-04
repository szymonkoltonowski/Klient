using Microsoft.EntityFrameworkCore;
using Klient.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klient.Model.Configuration
{
    public class KlientEntityConfiguration : IEntityTypeConfiguration<KlientEntity>
    {
        public void Configure(EntityTypeBuilder<KlientEntity> builder)
        {
            builder.HasKey(klient => klient.Id);

        }
    }
}
