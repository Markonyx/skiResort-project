using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkiResortService.Models
{
    public class Track
    {
        [Key]
        public int _id { get; set; }
        public int mountain_id { get; set; }
        public string name { get; set; }
        public decimal length_km { get; set; }
        public decimal rating { get; set; }
        public string color { get; set; }
    }
}