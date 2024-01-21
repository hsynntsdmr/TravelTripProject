using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProject.Models;
namespace TravelTripProject.Models
{
    public class BlogYorum
    {

        public IEnumerable <Blog> blogList { get; set; }
        public IEnumerable<Blog> sonBlogList { get; set; }
        public IEnumerable <Yorum> yorumList { get; set; }
        public IEnumerable<Yorum> sonYorumList { get; set; }
    }
}