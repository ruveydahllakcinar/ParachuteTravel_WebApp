﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ParachuteTravel.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AjaxCityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public AjaxCityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);   
            return Json(values);
        }

        public IActionResult GetById(int DestinationId)
        {
            var values = _destinationService.TGetById(DestinationId);
            var jsonCity = JsonConvert.SerializeObject(values);
            return Json(jsonCity);

        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();

        }

        public IActionResult UpdateCity(Destination destination)
        {
            var values = _destinationService.TGetById(destination.DestinationId);
            _destinationService.TUpdate(values);
            var v1 = JsonConvert.SerializeObject(destination);
            return Json(v1);
        }
    }
}
