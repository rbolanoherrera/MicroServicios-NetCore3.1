using Lil.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lil.Products.DAL
{
    public class ProductsProviders : IProductsProvider
    {
        private List<Product> repo = new List<Product>();
        public ProductsProviders()
        {
            for (int i = 1; i <= 100; i++)
            {
                repo.Add(new Product() { 
                    Id = i.ToString(), 
                    Name = $"Producto {i}",
                    Price = i * 100,
                });
            }
        }

        public Task<Product> GetAsync(string id)
        {
            return Task.FromResult(repo.Find(p => p.Id.Equals(id)));
        }
    }
}
