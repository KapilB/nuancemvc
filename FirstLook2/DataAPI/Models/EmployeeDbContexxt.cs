using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstLook2.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(): base("empDb")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        
    }
}