﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupplierWebApp.Models;

namespace SupplierWebApp.Migrations
{
    [DbContext(typeof(SupplierContext))]
    [Migration("20200218093818_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SupplierWebApp.Models.Area", b =>
                {
                    b.Property<int>("AreaCod");

                    b.Property<string>("AreaName")
                        .HasMaxLength(10);

                    b.HasKey("AreaCod");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("SupplierWebApp.Models.BidType", b =>
                {
                    b.Property<int>("Code");

                    b.Property<string>("Name")
                        .HasMaxLength(10);

                    b.HasKey("Code");

                    b.ToTable("BidType");
                });

            modelBuilder.Entity("SupplierWebApp.Models.Bids", b =>
                {
                    b.Property<int>("BidNumber");

                    b.Property<int?>("OfferingCode");

                    b.Property<int?>("OfferingMethod");

                    b.Property<int?>("OfferingType");

                    b.Property<int?>("StatusFinancialCode")
                        .HasColumnName("Status_Financial_Code");

                    b.Property<int?>("StatusTechnicalCode")
                        .HasColumnName("Status_TechnicalCode");

                    b.Property<int?>("TecnicalDecisionCode")
                        .HasColumnName("TecnicalDecision_Code");

                    b.Property<string>("UserName")
                        .HasMaxLength(10);

                    b.HasKey("BidNumber");

                    b.HasIndex("OfferingCode");

                    b.HasIndex("OfferingMethod");

                    b.HasIndex("StatusFinancialCode");

                    b.HasIndex("StatusTechnicalCode");

                    b.HasIndex("UserName");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("SupplierWebApp.Models.Conditions", b =>
                {
                    b.Property<int>("Code")
                        .HasColumnName("code");

                    b.Property<int?>("BidNumber");

                    b.Property<DateTime?>("InsurancePayment")
                        .HasColumnType("datetime");

                    b.Property<int?>("PlaceCode");

                    b.Property<decimal?>("Price")
                        .HasColumnName("price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal?>("PrimaryInsurance")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int?>("SchoolCode");

                    b.HasKey("Code");

                    b.HasIndex("BidNumber");

                    b.HasIndex("PlaceCode");

                    b.HasIndex("SchoolCode");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("SupplierWebApp.Models.Details", b =>
                {
                    b.Property<int>("Code");

                    b.Property<string>("Amount")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("SupplyDate")
                        .HasColumnType("date");

                    b.Property<string>("Value")
                        .HasMaxLength(10);

                    b.HasKey("Code");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("SupplierWebApp.Models.OfferingMethod", b =>
                {
                    b.Property<int>("Code");

                    b.Property<string>("Name")
                        .HasMaxLength(10);

                    b.HasKey("Code");

                    b.ToTable("OfferingMethod");
                });

            modelBuilder.Entity("SupplierWebApp.Models.OfferingType", b =>
                {
                    b.Property<int>("OfferingCod");

                    b.Property<string>("OfferingName")
                        .HasMaxLength(10);

                    b.HasKey("OfferingCod");

                    b.ToTable("OfferingType");
                });

            modelBuilder.Entity("SupplierWebApp.Models.Place", b =>
                {
                    b.Property<int>("Code");

                    b.Property<string>("Branches")
                        .HasMaxLength(10);

                    b.Property<string>("Comission")
                        .HasMaxLength(10);

                    b.Property<int?>("ConditionCode");

                    b.HasKey("Code");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("SupplierWebApp.Models.School", b =>
                {
                    b.Property<int>("Code");

                    b.Property<int?>("ConditionCode");

                    b.Property<string>("Name")
                        .HasMaxLength(10);

                    b.HasKey("Code");

                    b.ToTable("school");
                });

            modelBuilder.Entity("SupplierWebApp.Models.StatusFinacialDecision", b =>
                {
                    b.Property<int>("Code");

                    b.Property<string>("Name")
                        .HasMaxLength(10);

                    b.HasKey("Code");

                    b.ToTable("Status_FinacialDecision");
                });

            modelBuilder.Entity("SupplierWebApp.Models.StatusSpplyOrder", b =>
                {
                    b.Property<int>("Code");

                    b.Property<bool?>("Name");

                    b.HasKey("Code")
                        .HasName("PK_Status");

                    b.ToTable("Status_SpplyOrder");
                });

            modelBuilder.Entity("SupplierWebApp.Models.StatusTechnicalDecision", b =>
                {
                    b.Property<int>("Code");

                    b.Property<string>("Name")
                        .HasMaxLength(10);

                    b.HasKey("Code");

                    b.ToTable("Status_TechnicalDecision");
                });

            modelBuilder.Entity("SupplierWebApp.Models.SupplierType", b =>
                {
                    b.Property<int>("SuuplierCod");

                    b.Property<string>("SuopplierName")
                        .HasMaxLength(10);

                    b.HasKey("SuuplierCod");

                    b.ToTable("SupplierType");
                });

            modelBuilder.Entity("SupplierWebApp.Models.SupplyOrder", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("DetailsCode");

                    b.Property<int?>("OrderNumber");

                    b.Property<string>("SchoolName")
                        .HasMaxLength(10);

                    b.Property<int?>("StatusCode");

                    b.Property<DateTime?>("SupplyDate")
                        .HasColumnType("date");

                    b.Property<string>("UserName")
                        .HasMaxLength(10);

                    b.HasKey("Code");

                    b.HasIndex("DetailsCode");

                    b.HasIndex("StatusCode");

                    b.HasIndex("UserName");

                    b.ToTable("SupplyOrder");
                });

            modelBuilder.Entity("SupplierWebApp.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(10);

                    b.Property<string>("Address")
                        .HasMaxLength(10);

                    b.Property<int?>("AreaCode");

                    b.Property<string>("Balance")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .HasMaxLength(10);

                    b.Property<string>("NickName")
                        .HasMaxLength(10);

                    b.Property<string>("Phone")
                        .HasMaxLength(10);

                    b.Property<int?>("SuuplierCode");

                    b.HasKey("UserName");

                    b.HasIndex("AreaCode");

                    b.HasIndex("SuuplierCode");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SupplierWebApp.Models.Bids", b =>
                {
                    b.HasOne("SupplierWebApp.Models.BidType", "BidNumberNavigation")
                        .WithOne("Bids")
                        .HasForeignKey("SupplierWebApp.Models.Bids", "BidNumber")
                        .HasConstraintName("FK_Bids_BidType");

                    b.HasOne("SupplierWebApp.Models.OfferingType", "OfferingCodeNavigation")
                        .WithMany("Bids")
                        .HasForeignKey("OfferingCode")
                        .HasConstraintName("FK_Bids");

                    b.HasOne("SupplierWebApp.Models.OfferingMethod", "OfferingMethodNavigation")
                        .WithMany("Bids")
                        .HasForeignKey("OfferingMethod")
                        .HasConstraintName("FK_Bids_OfferingMethod");

                    b.HasOne("SupplierWebApp.Models.StatusFinacialDecision", "StatusFinancialCodeNavigation")
                        .WithMany("Bids")
                        .HasForeignKey("StatusFinancialCode")
                        .HasConstraintName("FK_Bids_Status_FinacialDecision");

                    b.HasOne("SupplierWebApp.Models.StatusTechnicalDecision", "StatusTechnicalCodeNavigation")
                        .WithMany("Bids")
                        .HasForeignKey("StatusTechnicalCode")
                        .HasConstraintName("FK_Bids_Status_TechnicalDecision");

                    b.HasOne("SupplierWebApp.Models.User", "UserNameNavigation")
                        .WithMany("Bids")
                        .HasForeignKey("UserName")
                        .HasConstraintName("FK_Bids_User");
                });

            modelBuilder.Entity("SupplierWebApp.Models.Conditions", b =>
                {
                    b.HasOne("SupplierWebApp.Models.Bids", "BidNumberNavigation")
                        .WithMany("Conditions")
                        .HasForeignKey("BidNumber")
                        .HasConstraintName("FK_Conditions_Bids");

                    b.HasOne("SupplierWebApp.Models.Place", "PlaceCodeNavigation")
                        .WithMany("Conditions")
                        .HasForeignKey("PlaceCode")
                        .HasConstraintName("FK_Conditions_Place");

                    b.HasOne("SupplierWebApp.Models.School", "SchoolCodeNavigation")
                        .WithMany("Conditions")
                        .HasForeignKey("SchoolCode")
                        .HasConstraintName("FK_Conditions_school");
                });

            modelBuilder.Entity("SupplierWebApp.Models.SupplyOrder", b =>
                {
                    b.HasOne("SupplierWebApp.Models.Details", "DetailsCodeNavigation")
                        .WithMany("SupplyOrder")
                        .HasForeignKey("DetailsCode")
                        .HasConstraintName("FK_SupplyOrder");

                    b.HasOne("SupplierWebApp.Models.StatusSpplyOrder", "StatusCodeNavigation")
                        .WithMany("SupplyOrder")
                        .HasForeignKey("StatusCode")
                        .HasConstraintName("FK_SupplyOrder_Status");

                    b.HasOne("SupplierWebApp.Models.User", "UserNameNavigation")
                        .WithMany("SupplyOrder")
                        .HasForeignKey("UserName")
                        .HasConstraintName("FK_SupplyOrder_User");
                });

            modelBuilder.Entity("SupplierWebApp.Models.User", b =>
                {
                    b.HasOne("SupplierWebApp.Models.Area", "AreaCodeNavigation")
                        .WithMany("User")
                        .HasForeignKey("AreaCode")
                        .HasConstraintName("FK_User_Area");

                    b.HasOne("SupplierWebApp.Models.SupplierType", "SuuplierCodeNavigation")
                        .WithMany("User")
                        .HasForeignKey("SuuplierCode")
                        .HasConstraintName("FK_User_User");
                });
#pragma warning restore 612, 618
        }
    }
}
