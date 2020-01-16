using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkiResortService.Models
{
    public class Weather
    {
        [Key]
        public int _id { get; set; }
        public int mountain_id { get; set; }
        public string date { get; set; }
        public int temperature_min { get; set; }
        public int temperature_max { get; set; }
        public decimal wind { get; set; }
        public string outlook { get; set; }
    }
}