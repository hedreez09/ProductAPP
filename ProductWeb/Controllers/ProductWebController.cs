using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductWeb.Controllers
{
	public class ProductWebController : Controller
	{
		Uri baseAddress = new Uri("https://localhost:44337/api/");
		HttpClient client;
		public ProductWebController()
		{
			client = new HttpClient();
			client.BaseAddress = baseAddress;
		}

		public IActionResult ProductIndex()
		{
			List<ProductDTO> product = new List<ProductDTO>();
			HttpResponseMessage response = client.GetAsync(client.BaseAddress + "products").Result;
			if (response.IsSuccessStatusCode)
			{
				string data = response.Content.ReadAsStringAsync().Result;
				product = JsonConvert.DeserializeObject<List<ProductDTO>>(data);
			}
			return View(product);
		}
	}
}
