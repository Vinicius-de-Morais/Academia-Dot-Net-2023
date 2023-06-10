using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace aula31;

public partial class AulaTesteContext : DbContext
{
    public AulaTesteContext()
    {
    }

    public AulaTesteContext(DbContextOptions<AulaTesteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Emails2> Emails2s { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    public virtual DbSet<Pessoas2> Pessoas2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=AulaTeste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasIndex(e => e.Pessoaid, "IX_Emails_pessoaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email1).HasColumnName("email");
            entity.Property(e => e.Pessoaid).HasColumnName("pessoaid");

            entity.HasOne(d => d.Pessoa).WithMany(p => p.Emails)
                .HasForeignKey(d => d.Pessoaid)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Emails2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__emails2__3213E83F310331C2");

            entity.ToTable("emails2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FkPessoa).HasColumnName("fk_pessoa");

            entity.HasOne(d => d.FkPessoaNavigation).WithMany(p => p.Emails2s)
                .HasForeignKey(d => d.FkPessoa)
                .HasConstraintName("FK__emails2__fk_pess__52593CB8");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Pessoas2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pessoas2__3213E83F891CEC83");

            entity.ToTable("pessoas2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
