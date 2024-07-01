using System;
using System.Collections.Generic;
using AlorTest.Repository.DBModels;
using Microsoft.EntityFrameworkCore;

namespace AlorTest.Repository;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-9KQ0FA6\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;Trust Server Certificate=True");
    }

    public virtual DbSet<DownloadedFile> DownloadedFiles { get; set; }
    public virtual DbSet<Entity> Entities { get; set; }
    public virtual DbSet<Individual> Individuals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DownloadedFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Files__3213E83F9A72F920");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FileType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity.HasKey(entity => entity.Id);
        });

        modelBuilder.Entity<Individual>(individual =>
        {
            individual.HasKey(individual => individual.Id);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
