﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string  Mail { get; set; }
        public string BlogYorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    
    
    }
}