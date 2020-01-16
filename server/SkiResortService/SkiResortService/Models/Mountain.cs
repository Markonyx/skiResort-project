using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkiResortService.Models
{
    public class Mountain
    {
        [Key]
        public int _id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string country { get; set; }
        public string highest_point { get; set; }
        public int top_elevation_m { get; set; }
        public int base_elevation_m { get; set; }
        public string picture { get; set; }
    }
}