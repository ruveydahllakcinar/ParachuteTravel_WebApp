﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string CityName { get; set; }
        public string DayNight { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string CoverImage { get; set; }
        public string Details { get; set; }
        public string Details2 { get; set; }
        public string ImageDetail { get; set; }
        public DateTime BlogDate { get; set; }
        public DateTime ShareDate { get; set; }
        public List<Comment>Comments { get; set; }
        public List<Reservation>Reservations { get; set; }
        public int? GuideId { get; set; }
        public Guide Guide { get; set; }
    }
}
