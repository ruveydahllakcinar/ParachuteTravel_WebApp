using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Queries.DestinationQuery
{
    public class GetDestinationByIdQuery
    {
        public GetDestinationByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
