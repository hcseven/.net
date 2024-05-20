using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelApp.Models.Classes
{
    public class BlogComments
    {

        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Comment> Comments { get; set;}


    }
}