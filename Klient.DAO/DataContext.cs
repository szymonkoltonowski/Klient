using Klient.Application.Configuration;
using Klient.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Klient.DAO
{
    public class DataContext : DbContext, IDataContext
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
                .OnDelete(DeleteBehavior.Cascade);
                
                
            modelBuilder.ApplyConfiguration(new KlientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AdresEntityConfiguration());


            base.OnModelCreating(modelBuilder);



        }

    }
}
