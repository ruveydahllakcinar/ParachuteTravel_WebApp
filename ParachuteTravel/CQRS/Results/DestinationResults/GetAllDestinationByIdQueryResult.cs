using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Results.DestinationResults
{
    public class GetAllDestinationByIdQueryResult
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
    }
}
