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
    public class BookingExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
			List<BookingExchangeViewModel> bookingExchangeViewModels = new List<BookingExchangeViewModel>();

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=AED"),
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
				var values = JsonConvert.DeserializeObject<BookingExchangeViewModel>(body);
				return View(values.exchange_rates);
			}
		}
    }
}
