using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommands
    {
      
        public string CityName { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }


        
    }
}
