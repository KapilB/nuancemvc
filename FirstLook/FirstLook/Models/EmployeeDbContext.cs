using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstLook.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base ("EmpContext")
        {
            //
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}