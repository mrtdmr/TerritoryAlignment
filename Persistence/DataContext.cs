using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<City> Cities { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanMarket> PlanMarkets { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Deduction> Deductions { get; set; }
        public DbSet<DeductionDetail> DeductionDetails { get; set; }
        public DbSet<Induction> Inductions { get; set; }
        public DbSet<InductionDetail> InductionDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<MarketCity> MarketCities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentCity> DepartmentCities { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<City>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Plan>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<PlanCity>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<PlanMarket>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<PlanDepartment>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Segment>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Team>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Deduction>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<DeductionDetail>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Induction>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<InductionDetail>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Product>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Market>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<MarketCity>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<Department>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //    modelBuilder.Entity<DepartmentCity>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        //}
    }
}
