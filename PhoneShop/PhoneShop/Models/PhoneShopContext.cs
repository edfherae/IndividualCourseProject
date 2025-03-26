using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhoneShop.Models;

public partial class PhoneShopContext : DbContext
{
    public PhoneShopContext()
    {
    }

    public PhoneShopContext(DbContextOptions<PhoneShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Phone> Phones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-OKGA20J\\SQLEXPRESS;Database=PhoneShop;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.PhoneId).HasName("PK__Phones__E6BD6DD7A22EB3D7");

            entity.Property(e => e.PhoneId)
                .ValueGeneratedNever()
                .HasColumnName("phone_id");
            entity.Property(e => e.Country)
                .HasMaxLength(16)
                .HasColumnName("country");
            entity.Property(e => e.ImageLocation).HasColumnName("image_location");
            entity.Property(e => e.Model)
                .HasMaxLength(32)
                .HasColumnName("model");
            entity.Property(e => e.Producer)
                .HasMaxLength(16)
                .HasColumnName("producer");
            entity.Property(e => e.YearOfRelease)
                .HasColumnType("datetime")
                .HasColumnName("year_of_release");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
