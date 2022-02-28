using ProductAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Repository
{
	public class ProductRepository
	{
		private readonly List<ProductEntity> product = new()
		{
			new ProductEntity { ProductId = 1, Name = "Laptop", Description = "Fresh from Uk", Price = 2m },
			new ProductEntity { ProductId = 2, Name = "Phone", Description = "Fresh from Uk", Price = 250 },
			new ProductEntity { ProductId = 3, Name = "Modem", Description = "Fresh from Uk", Price = 50 },
			new ProductEntity { ProductId = 4, Name = "Bag", Description = "Fresh from Uk", Price = 10 },
			new ProductEntity { ProductId = 5, Name = "Flask", Description = "Fresh from Uk", Price = 10 },
		};

		public IEnumerable<ProductEntity> GetProducts()
		{
			return product;
		}

		public ProductEntity GetProduct(int id)
		{
			return product.Where(item => item.ProductId == id).SingleOrDefault();
		}
	}
}
