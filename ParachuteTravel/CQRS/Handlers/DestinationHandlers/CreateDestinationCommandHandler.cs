using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using ParachuteTravel.CQRS.Commands.DestinationCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;
        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommands command)
        {
            _context.Destinations.Add(new Destination
            {
                CityName = command.CityName,
                Price = command.Price,
                DayNight = command.DayNight,
                Capacity = command.Capacity,
                Status = true

            });
            _context.SaveChanges();
        }
    }
}
