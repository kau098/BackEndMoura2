using System;
using System.Collections.Generic;
using DevConnectMoura.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comentario> Comentario { get; set; }

    public virtual DbSet<TbCurtidas> TbCurtidas { get; set; }

    public virtual DbSet<TbPubli> TbPubli { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_Windows");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.ComentarioId).HasName("PK__comentar__F1844938E4043EEB");

            entity.Property(e => e.DataComentario).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdPubliNavigation).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__comentari__ID_Pu__09A971A2");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__comentari__Usuar__08B54D69");
        });

        modelBuilder.Entity<TbCurtidas>(entity =>
        {
            entity.HasKey(e => e.IdCurtidas).HasName("PK__tb_curti__EDCB91053CAF4A7C");

            entity.HasOne(d => d.IdPubliNavigation).WithMany(p => p.TbCurtidas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__ID_Pu__778AC167");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtidas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__ID_Pu__76969D2E");
        });

        modelBuilder.Entity<TbPubli>(entity =>
        {
            entity.HasKey(e => e.IdPubli).HasName("PK__tb_publi__5A27A42F089B3965");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPubli).HasConstraintName("FK__tb_publi__ID_Usu__73BA3083");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__tb_usuar__DE4431C501A1C727");

            entity.HasMany(d => d.IdUsuarioSeguido).WithMany(p => p.IdUsuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguido")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__7F2BE32F"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__7E37BEF6"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguidor", "IdUsuarioSeguido").HasName("PK__tb_segui__1132BEECFBB13256");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("id_usuario_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguido").HasColumnName("id_usuario_seguido");
                    });

            entity.HasMany(d => d.IdUsuarioSeguidor).WithMany(p => p.IdUsuarioSeguido)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__7E37BEF6"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguido")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__7F2BE32F"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguidor", "IdUsuarioSeguido").HasName("PK__tb_segui__1132BEECFBB13256");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("id_usuario_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguido").HasColumnName("id_usuario_seguido");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
