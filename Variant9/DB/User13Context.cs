using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Variant9.DB;

public partial class User13Context : DbContext
{
    public User13Context()
    {
    }

    public User13Context(DbContextOptions<User13Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Creator> Creators { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=192.168.200.35;database=user13;user=user13;password=41225;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Creator>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Good>(entity =>
        {
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Articul)
                .HasMaxLength(50)
                .HasColumnName("articul");
            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.CreatorId).HasColumnName("creatorID");
            entity.Property(e => e.CurrentSale).HasColumnName("currentSale");
            entity.Property(e => e.Discription)
                .HasMaxLength(200)
                .HasColumnName("discription");
            entity.Property(e => e.MaxSaleProc).HasColumnName("maxSaleProc");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Picture)
                .HasMaxLength(2000)
                .HasColumnName("picture");
            entity.Property(e => e.ProviderId).HasColumnName("providerID");
            entity.Property(e => e.UnitId).HasColumnName("unitID");

            entity.HasOne(d => d.Category).WithMany(p => p.Goods)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Goods_Categories");

            entity.HasOne(d => d.Creator).WithMany(p => p.Goods)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Goods_Creators");

            entity.HasOne(d => d.Provider).WithMany(p => p.Goods)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Goods_Providers");

            entity.HasOne(d => d.Unit).WithMany(p => p.Goods)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Goods_Units");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .HasColumnName("pass");
            entity.Property(e => e.RoleId).HasColumnName("roleID");
            entity.Property(e => e.SecondName)
                .HasMaxLength(50)
                .HasColumnName("secondName");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
