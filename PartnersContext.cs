using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PR4;

public partial class PartnersContext : DbContext
{
    public PartnersContext()
    {
    }

    public PartnersContext(DbContextOptions<PartnersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Partner> Partner { get; set; }

    public virtual DbSet<PartnersProduct> PartnersProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TypeOfPartner> TypeOfPartners { get; set; }

    public virtual DbSet<TypeProduct> TypeProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Partners;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_pkey");

            entity.Property(e => e.Inn).HasColumnName("INN");

            entity.HasOne(d => d.TypeOfPartner).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdTypeOfPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partners_typesOfPartner");
        });

        modelBuilder.Entity<PartnersProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_Products_pkey");

            entity.ToTable("Partners_Products");

            entity.Property(e => e.SalesDate).HasColumnType("time with time zone");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_IdPartner");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_IdProduct");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.Property(e => e.MinimumCostForApartner)
                .HasColumnType("money")
                .HasColumnName("MinimumCostForAPartner");

            entity.HasOne(d => d.TypeProduct).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_typesOfProduct");
        });

        modelBuilder.Entity<TypeOfPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypeOfPartners_pkey");

            entity.Property(e => e.TypeOfPartner1).HasColumnName("TypeOfPartner");
        });

        modelBuilder.Entity<TypeProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypeProducts_pkey");

            entity.Property(e => e.TypeProduct1).HasColumnName("TypeProduct");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
