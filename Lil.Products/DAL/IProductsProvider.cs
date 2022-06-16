using Lil.Products.Models;
using System.Threading.Tasks;

namespace Lil.Products.DAL
{
    public interface IProductsProvider
    {
        Task<Product> GetAsync(string id);
    }
}
