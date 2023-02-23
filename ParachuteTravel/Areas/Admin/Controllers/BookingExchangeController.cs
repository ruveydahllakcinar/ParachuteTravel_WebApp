using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ParachuteTravel.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
			List<BookingExchangeViewModel2> bookingExchangeViewModels = new List<BookingExchangeViewModel2>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=TRY"),
				Headers =
	{
		{ "X-RapidAPI-Key", "5e68397f7bmsh0690ced80ffafdbp19b990jsn5cc879316e96" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using(var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
				return View(values.exchange_rates);
			}
			
        }
    }
}
