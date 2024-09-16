using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication5.Models
{
    public partial class interviewContext : DbContext
    {
        public interviewContext()
        {
        }

        public interviewContext(DbContextOptions<interviewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-L4AJ2L9;Initial Catalog=interview;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalityId).HasColumnName("nationalityId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
