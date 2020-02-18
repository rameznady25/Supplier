using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SupplierWebApp.Models
{
    public partial class SupplierContext : DbContext
    {
        public SupplierContext()
        {
        }

        public SupplierContext(DbContextOptions<SupplierContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<BidType> BidType { get; set; }
        public virtual DbSet<Bids> Bids { get; set; }
        public virtual DbSet<Conditions> Conditions { get; set; }
        public virtual DbSet<Details> Details { get; set; }
        public virtual DbSet<OfferingMethod> OfferingMethod { get; set; }
        public virtual DbSet<OfferingType> OfferingType { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<StatusFinacialDecision> StatusFinacialDecision { get; set; }
        public virtual DbSet<StatusSpplyOrder> StatusSpplyOrder { get; set; }
        public virtual DbSet<StatusTechnicalDecision> StatusTechnicalDecision { get; set; }
        public virtual DbSet<SupplierType> SupplierType { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrder { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Supplier;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.AreaCod);

                entity.Property(e => e.AreaCod).ValueGeneratedNever();

                entity.Property(e => e.AreaName).HasMaxLength(10);
            });

            modelBuilder.Entity<BidType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Bids>(entity =>
            {
                entity.HasKey(e => e.BidNumber);

                entity.Property(e => e.BidNumber).ValueGeneratedNever();

                entity.Property(e => e.StatusFinancialCode).HasColumnName("Status_Financial_Code");

                entity.Property(e => e.StatusTechnicalCode).HasColumnName("Status_TechnicalCode");

                entity.Property(e => e.TecnicalDecisionCode).HasColumnName("TecnicalDecision_Code");

                entity.Property(e => e.UserName).HasMaxLength(10);

                entity.HasOne(d => d.BidNumberNavigation)
                    .WithOne(p => p.Bids)
                    .HasForeignKey<Bids>(d => d.BidNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bids_BidType");

                entity.HasOne(d => d.OfferingCodeNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.OfferingCode)
                    .HasConstraintName("FK_Bids");

                entity.HasOne(d => d.OfferingMethodNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.OfferingMethod)
                    .HasConstraintName("FK_Bids_OfferingMethod");

                entity.HasOne(d => d.StatusFinancialCodeNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.StatusFinancialCode)
                    .HasConstraintName("FK_Bids_Status_FinacialDecision");

                entity.HasOne(d => d.StatusTechnicalCodeNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.StatusTechnicalCode)
                    .HasConstraintName("FK_Bids_Status_TechnicalDecision");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_Bids_User");
            });

            modelBuilder.Entity<Conditions>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.InsurancePayment).HasColumnType("datetime");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrimaryInsurance).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BidNumberNavigation)
                    .WithMany(p => p.Conditions)
                    .HasForeignKey(d => d.BidNumber)
                    .HasConstraintName("FK_Conditions_Bids");

                entity.HasOne(d => d.PlaceCodeNavigation)
                    .WithMany(p => p.Conditions)
                    .HasForeignKey(d => d.PlaceCode)
                    .HasConstraintName("FK_Conditions_Place");

                entity.HasOne(d => d.SchoolCodeNavigation)
                    .WithMany(p => p.Conditions)
                    .HasForeignKey(d => d.SchoolCode)
                    .HasConstraintName("FK_Conditions_school");
            });

            modelBuilder.Entity<Details>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.SupplyDate).HasColumnType("date");

                entity.Property(e => e.Value).HasMaxLength(10);
            });

            modelBuilder.Entity<OfferingMethod>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<OfferingType>(entity =>
            {
                entity.HasKey(e => e.OfferingCod);

                entity.Property(e => e.OfferingCod).ValueGeneratedNever();

                entity.Property(e => e.OfferingName).HasMaxLength(10);
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Branches).HasMaxLength(10);

                entity.Property(e => e.Comission).HasMaxLength(10);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("school");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<StatusFinacialDecision>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Status_FinacialDecision");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<StatusSpplyOrder>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_Status");

                entity.ToTable("Status_SpplyOrder");

                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<StatusTechnicalDecision>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Status_TechnicalDecision");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.HasKey(e => e.SuuplierCod);

                entity.Property(e => e.SuuplierCod).ValueGeneratedNever();

                entity.Property(e => e.SuopplierName).HasMaxLength(10);
            });

            modelBuilder.Entity<SupplyOrder>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SchoolName).HasMaxLength(10);

                entity.Property(e => e.SupplyDate).HasColumnType("date");

                entity.Property(e => e.UserName).HasMaxLength(10);

                entity.HasOne(d => d.DetailsCodeNavigation)
                    .WithMany(p => p.SupplyOrder)
                    .HasForeignKey(d => d.DetailsCode)
                    .HasConstraintName("FK_SupplyOrder");

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.SupplyOrder)
                    .HasForeignKey(d => d.StatusCode)
                    .HasConstraintName("FK_SupplyOrder_Status");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.SupplyOrder)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_SupplyOrder_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(10);

                entity.Property(e => e.Balance).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(10);

                entity.Property(e => e.FirstName).HasMaxLength(10);

                entity.Property(e => e.NickName).HasMaxLength(10);

                entity.Property(e => e.Phone).HasMaxLength(10);

                entity.HasOne(d => d.AreaCodeNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AreaCode)
                    .HasConstraintName("FK_User_Area");

                entity.HasOne(d => d.SuuplierCodeNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.SuuplierCode)
                    .HasConstraintName("FK_User_User");
            });
        }
    }
}
