using System;
using System.Collections.Generic;
using ComercioExterior.Models;
using Microsoft.EntityFrameworkCore;

namespace ComercioExterior.Context;

public partial class Eff2Context : DbContext
{
    public Eff2Context()
    {
    }

    public Eff2Context(DbContextOptions<Eff2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Puerto> Puertos { get; set; }

    public virtual DbSet<Transaccion> Transaccions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Detpc\\SQLEXPRESS; Initial Catalog=EFF_2; Integrated Security=True; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CLIENTES__3214EC270AA2F2DE");

            entity.ToTable("CLIENTES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Cedula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRES");
        });

        modelBuilder.Entity<Puerto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PUERTOS__3214EC278C155F76");

            entity.ToTable("PUERTOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
        });

        modelBuilder.Entity<Transaccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRANSACC__3214EC27A851A5FC");

            entity.ToTable("TRANSACCION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMENTARIOS");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");
            entity.Property(e => e.IdPuerto).HasColumnName("ID_PUERTO");
            entity.Property(e => e.TipoTransaccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_TRANSACCION");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_01_TRANSACCION");

            entity.HasOne(d => d.IdPuertoNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.IdPuerto)
                .HasConstraintName("FK_02_TRANSACCION");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
