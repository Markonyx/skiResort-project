using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkiResortService.Models
{
    public class Reservation
    {
        [Key]
        public int _id { get; set; }
        public int mountain_id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public ReservationDate from { get; set; }
        public ReservationDate to { get; set; }
        public int price { get; set; }
    }
}