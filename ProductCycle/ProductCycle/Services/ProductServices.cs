using ProductCycle.Models;

namespace ProductCycle.Services
{
    public class ProductServices : IProductServices
    {
        public ProductDBContext _dbContext;
        public ProductServices(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}
