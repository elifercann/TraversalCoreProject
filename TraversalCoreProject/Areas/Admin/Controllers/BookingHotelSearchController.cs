using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?units=metric&checkin_date=2023-02-17&dest_type=city&dest_id=-1456928&checkout_date=2023-02-18&order_by=popularity&filter_by_currency=EUR&locale=en-gb&adults_number=2&room_number=1&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_number=2&children_ages=5%2C0&page_number=0"),
				Headers =
	{
		{ "X-RapidAPI-Key", "ee75e47597msh79a71ed12b9b576p110888jsn2c5691d8c2fb" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var bodyReplace = body.Replace(".", "");
				var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
				return View(values.results);
			}
		}

		[HttpGet]
		public IActionResult GetCityId()
        {
			return View();
        }

		[HttpPost]
		public async Task<IActionResult> GetCityId(string p)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={p}"),
				Headers =
	{
		{ "X-RapidAPI-Key", "ee75e47597msh79a71ed12b9b576p110888jsn2c5691d8c2fb" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				
			}
			return View();
        }
    
	
	}
}
