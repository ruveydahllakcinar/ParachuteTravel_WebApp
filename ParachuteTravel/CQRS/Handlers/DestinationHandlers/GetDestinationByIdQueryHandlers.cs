using DataAccessLayer.Concrete;
using ParachuteTravel.CQRS.Queries.DestinationQuery;
using ParachuteTravel.CQRS.Results.DestinationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandlers
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandlers(Context context)
        {
            _context = context;
        }

        public GetAllDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetAllDestinationByIdQueryResult
            {
                DestinationId = values.DestinationId,
                City = values.CityName,
                DayNight = values.DayNight
            };
        }

    }
}
