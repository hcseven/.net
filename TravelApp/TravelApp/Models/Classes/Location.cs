using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelApp.Models.Classes
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string MyAddress {  get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        public string Subject { get; set; }
    }
}