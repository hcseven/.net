using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelApp.Models.Classes
{
    public class About
    {
        [Key]
        public int id { get; set; }

        public string ImageUrl { get; set; }

        public string MyAbout { get; set; }
    }
}