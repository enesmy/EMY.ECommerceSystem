using EMY.ECommerceSystem.Core.Domain.Entities;

namespace EMY.ECommerceSystem.Core.Application.Abstractions
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product, int creater);
        void UpdateProduct(Product product, int updater);
        void DeleteProduct(int id, int deleter);
        
    }
}
