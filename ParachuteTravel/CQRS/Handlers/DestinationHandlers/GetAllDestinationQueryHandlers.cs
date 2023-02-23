using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using ParachuteTravel.CQRS.Queries.DestinationQuery;
using ParachuteTravel.CQRS.Results.DestinationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandlers
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandlers(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle(/*GetAllDestinationQuery query*/)
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationId,
                capacity = x.Capacity,
                city = x.CityName,
                daynight = x.DayNight,
                price = x.Price
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
