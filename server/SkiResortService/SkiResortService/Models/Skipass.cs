using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkiResortService.Models
{
    public class Skipass
    {
        [Key]
        public int _id { get; set; }
        public int mountain_id { get; set; }
        public int duration { get; set; }
        public int price { get; set; }
    }
}