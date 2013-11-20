using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstLook2.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Author { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

    }
}