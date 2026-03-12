using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirstApproach.Models;

public partial class DbFirstContext : DbContext
{
    public DbFirstContext()
    {
    }

    public DbFirstContext(DbContextOptions<DbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Borrower> Borrowers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RAGHVISHARMA\\SQLEXPRESS;Initial Catalog=DbFirst;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Authors__70DAFC343496DF27");

            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C20764660518");

            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasColumnName("ISBN");
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Books__AuthorId__5EBF139D");

            entity.HasMany(d => d.Borrowers).WithMany(p => p.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "BookBorrower",
                    r => r.HasOne<Borrower>().WithMany()
                        .HasForeignKey("BorrowerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BookBorro__Borro__6477ECF3"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BookBorro__BookI__6383C8BA"),
                    j =>
                    {
                        j.HasKey("BookId", "BorrowerId").HasName("PK__BookBorr__58882FB249FC21ED");
                        j.ToTable("BookBorrowers");
                    });
        });

        modelBuilder.Entity<Borrower>(entity =>
        {
            entity.HasKey(e => e.BorrowerId).HasName("PK__Borrower__568EDB577E570530");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
