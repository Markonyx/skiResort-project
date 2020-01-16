using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkiResortService.Models
{
    public class Skiresort
    {
        [Key]
        public int _id { get; set; }
        public string name { get; set; }
    }
}