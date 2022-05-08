using EMY.ECommerceSystem.Core.Application.Abstractions;
using EMY.ECommerceSystem.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMY.ECommerceSystem.Infrastructure.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public void CreateProduct(Product product, int creater)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id, int deleter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product, int updater)
        {
            throw new NotImplementedException();
        }
    }
}
