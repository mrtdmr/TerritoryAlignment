﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200418095645_DeductionDetailUpdate")]
    partial class DeductionDetailUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Domain.Deduction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("AnnualWorkingDay")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("AverageFrequency")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("DailyVisit")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("MonthlyTargetMPR")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("MonthlyTargetVisitFrequency")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("MonthlyVisitCapacity")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("MonthlyWorkingDay")
                        .HasColumnType("decimal(12,2)");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("TargetedTotalPhysician")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("TargetedTotalVisit")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("PlanId")
                        .IsUnique();

                    b.ToTable("Deduction");
                });

            modelBuilder.Entity("Domain.DeductionDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DeductionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PhysicianUniverse")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("PhysicianUniverseCovered")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("Scope")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("ScopeCount")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("DeductionId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DeductionDetail");
                });

            modelBuilder.Entity("Domain.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Domain.DepartmentCity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PhysicianCount")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentCity");
                });

            modelBuilder.Entity("Domain.Induction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("GeographicRatio")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("PhysicianRatio")
                        .HasColumnType("decimal(12,2)");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlanId")
                        .IsUnique();

                    b.ToTable("Induction");
                });

            modelBuilder.Entity("Domain.InductionDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InductionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Market")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("MarketGeographicRatio")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("PhysicianCount")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("PhysicianGeographicRatio")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("WeightedGeographicRatio")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("InductionId");

                    b.ToTable("InductionDetail");
                });

            modelBuilder.Entity("Domain.Market", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("Domain.MarketCity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(12,2)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MarketId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("MarketId");

                    b.ToTable("MarketCity");
                });

            modelBuilder.Entity("Domain.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<decimal>("ActualMPR")
                        .HasColumnType("decimal(12,2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DeductionMPR")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal?>("InductionMPR")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("MinimumScope")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("Domain.PlanMarket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MarketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MarketId");

                    b.HasIndex("PlanId");

                    b.ToTable("PlanMarket");
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("MarketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MarketId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Domain.Segment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DeductionDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("TargetCount")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("TargetFrequency")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("Visit")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("DeductionDetailId");

                    b.ToTable("Segment");
                });

            modelBuilder.Entity("Domain.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Domain.Deduction", b =>
                {
                    b.HasOne("Domain.Plan", "Plan")
                        .WithOne("Deduction")
                        .HasForeignKey("Domain.Deduction", "PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.DeductionDetail", b =>
                {
                    b.HasOne("Domain.Deduction", "Deduction")
                        .WithMany("DeductionDetails")
                        .HasForeignKey("DeductionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.DepartmentCity", b =>
                {
                    b.HasOne("Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Induction", b =>
                {
                    b.HasOne("Domain.Plan", "Plan")
                        .WithOne("Induction")
                        .HasForeignKey("Domain.Induction", "PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.InductionDetail", b =>
                {
                    b.HasOne("Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Induction", "Induction")
                        .WithMany("InductionDetails")
                        .HasForeignKey("InductionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.MarketCity", b =>
                {
                    b.HasOne("Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Market", "Market")
                        .WithMany()
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Plan", b =>
                {
                    b.HasOne("Domain.Team", "Team")
                        .WithMany("Plans")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.PlanMarket", b =>
                {
                    b.HasOne("Domain.Market", "Market")
                        .WithMany()
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.HasOne("Domain.Market", "Market")
                        .WithMany()
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Segment", b =>
                {
                    b.HasOne("Domain.DeductionDetail", "DeductionDetail")
                        .WithMany("Segments")
                        .HasForeignKey("DeductionDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
