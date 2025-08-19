using ProductCycle.Models;

namespace ProductCycle.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetProducts();
        int AddProduct(Product product);
    }
}
