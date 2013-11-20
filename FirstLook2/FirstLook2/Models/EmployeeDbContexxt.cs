using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstLook2.Models
{
    public class EmployeeDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Review> Reviews { get; set; }
        
    }
}