﻿using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Configuration;

namespace DataAccess
{
    public class LeaveTrackerDbContext : DbContext
    {
        public LeaveTrackerDbContext()
            : base("")//base(ConfigurationManager.ConnectionStrings[""].ConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Leaves> Leaves { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
       
    }
}
