using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelApp.Models.Classes
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string Image { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}