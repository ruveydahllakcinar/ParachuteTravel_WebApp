﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
