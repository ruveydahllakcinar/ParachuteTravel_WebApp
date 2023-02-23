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
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?room_number=1&checkout_date=2023-02-24&dest_type=city&dest_id=-1456928&adults_number=2&locale=en-gb&checkin_date=2023-02-23&order_by=popularity&filter_by_currency=AED&units=metric&page_number=0&children_number=2&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0"),
				Headers =
			{
				{ "X-RapidAPI-Key", "5e68397f7bmsh0690ced80ffafdbp19b990jsn5cc879316e96" },
				{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
			},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var bodyReplace = body.Replace(".", "");
				var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
				return View(values.result);

			}
        }

		[HttpGet]
		public IActionResult GetCityDestId()
        {
			return View();
        }

		[HttpPost]
		public async Task<IActionResult> GetCityDestId(string city)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name=city&locale=en-gb"),
				Headers =
			{
				{ "X-RapidAPI-Key", "5e68397f7bmsh0690ced80ffafdbp19b990jsn5cc879316e96" },
				{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
			},
					};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				return View();
			}
		}
    }
}
