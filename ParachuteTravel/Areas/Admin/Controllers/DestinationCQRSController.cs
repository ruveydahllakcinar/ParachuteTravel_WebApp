using Microsoft.AspNetCore.Mvc;
using ParachuteTravel.CQRS.Handlers.DestinationHandlers;
using ParachuteTravel.CQRS.Queries.DestinationQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandlers _getAllDestinationQueryHandlers;
        private readonly GetDestinationByIdQueryHandlers _getDestinationByIdQueryHandlers;

        public DestinationCQRSController(GetAllDestinationQueryHandlers getAllDestinationQueryHandlers, GetDestinationByIdQueryHandlers getDestinationByIdQueryHandlers)
        {
            _getAllDestinationQueryHandlers = getAllDestinationQueryHandlers;
            _getDestinationByIdQueryHandlers = getDestinationByIdQueryHandlers;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandlers.Handle();
            return View(values);
        }
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIdQueryHandlers.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }
    }
}
