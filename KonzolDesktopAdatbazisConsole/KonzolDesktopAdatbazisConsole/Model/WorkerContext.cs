using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace KonzolDesktopAdatbazisConsole.Model;

public partial class WorkerContext : DbContext
{
    public WorkerContext()
    {
    }

    public WorkerContext(DbContextOptions<WorkerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=worker;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_hungarian_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Worker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("worker")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Email)
                .HasMaxLength(26)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(14)
                .HasColumnName("name");
            entity.Property(e => e.Salary)
                .HasColumnType("int(6)")
                .HasColumnName("salary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
