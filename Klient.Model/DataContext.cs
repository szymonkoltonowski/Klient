using Klient.Model.Configuration;
using Klient.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Klient.Model
{
    public class DataContext : DbContext
    {

        public DbSet<KlientEntity> Klient { get; set; }
        public DbSet<AdresEntity> Adres { get; set; }

        public DataContext(DbContextOptions options)
       : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KlientEntity>()
                .HasOne<AdresEntity>(s => s.Adres)
                .WithMany(g => g.Klient)
                .HasForeignKey(s => s.AdresId)
                .IsRequired();
            modelBuilder.ApplyConfiguration(new KlientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AdresEntityConfiguration());


            //var AdresSeed = new AdresEntity()
            //{
            //    Id = Guid.NewGuid(),
            //    Miasto = "Toruń",
            //    NrDomu = "22",
            //    NrMieszkania = "1",
            //    Ulica = "Biała",
            //};
            //var KlientSeed = new KlientEntity()
            //{
            //    Id = Guid.NewGuid(),
            //    Pesel = "95232125123",
            //    Imie = "Szymek",
            //    Nazwisko = "Kolt",
            //    AdresId = AdresSeed.Id
            //};
 
            //modelBuilder.Entity<AdresEntity>().HasData(AdresSeed);
            //modelBuilder.Entity<KlientEntity>().HasData(KlientSeed);

            base.OnModelCreating(modelBuilder);



        }

    }
}
