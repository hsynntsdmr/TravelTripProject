using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string  Mail { get; set; }
        public string BlogYorum { get; set; }
        public Blog Blog { get; set; }
    }
}