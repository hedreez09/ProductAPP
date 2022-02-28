using Microsoft.AspNetCore.Mvc;
using ProductAPI.DTO;
using ProductAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly ProductRepository productRepo;
		public ProductsController()
		{
			productRepo = new ProductRepository();
		}

		//api/products
		[HttpGet]
		public IEnumerable<ProductEntity> Getproducts()
		{
			var products = productRepo.GetProducts();
			return products;
		}

		//api/products/2
		[HttpGet("{id}")]
		public ProductEntity GetProduct(int id)
		{
			var product = productRepo.GetProduct(id);
			return product;
		}
	}
}
