using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstLook.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Author { get; set; }
        public string CommentText { get; set; }
        public int Rating { get; set; }
    }
}