using DataAccessLayer.Concrete;
using ParachuteTravel.CQRS.Queries.DestinationQueries;
using ParachuteTravel.CQRS.Results.DestinationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationId,
                City = values.CityName,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
    }
}
