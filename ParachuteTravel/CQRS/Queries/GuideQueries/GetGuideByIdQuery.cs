using MediatR;
using ParachuteTravel.CQRS.Results.GuideResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }
    }
}
