using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dynamic_User_Defined_Dashboards.Models
{
    public partial class Dashboard_FormContext : DbContext
    {
        public Dashboard_FormContext()
        {
        }

        public Dashboard_FormContext(DbContextOptions<Dashboard_FormContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<DashboardsInfo> DashboardsInfo { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        public virtual DbSet<SavedFormsList> SavedFormsList { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=root@123" +
                    ";database=Dynamic_Form");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<DashboardsInfo>(entity =>
            {
                entity.ToTable("Dashboards_Info", "Dynamic_Form");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SavedFormsList>(entity =>
            {
                entity.ToTable("SavedFormsList", "Dynamic_Form");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(258)
                    .IsUnicode(false);

                entity.Property(e => e.FormData)
                    .IsRequired()
                    .HasMaxLength(258)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedData)
                .IsRequired()
                .HasMaxLength(258)
                .IsUnicode(false);

            });

            modelBuilder.Entity<Templates>(entity =>
            {
                entity.ToTable("Templates", "Dynamic_Form");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ElementsCount).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
