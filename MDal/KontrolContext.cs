using MModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDal
{
    public class KontrolContext:DbContext
    {
        public KontrolContext():base("cstr")
        {

        }
        public DbSet<Musteri> Musteriler { get; set; }
       
        public DbSet<Paket> Paketler { get; set; }


       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().ToTable("tblMusteriler");

            modelBuilder.Entity<Musteri>().Property(m => m.Ad).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Adres).IsRequired().HasMaxLength(255).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Tc).IsRequired().HasMaxLength(15).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Telefon).IsRequired().HasMaxLength(25).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.Taahut).IsRequired().HasMaxLength(25).HasColumnType("varchar");

            modelBuilder.Entity<Paket>().ToTable("tblPaketler");
            modelBuilder.Entity<Paket>().Property(p => p.PaketAd).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Paket>().Property(p => p.PaketFiyat).IsRequired().HasMaxLength(50).HasColumnType("varchar");

        }
    }
}
