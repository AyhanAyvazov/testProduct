using ProductWithCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithCategory.Repositories
{
    public interface IProductRepository 
    {
        List<Product> GetAll();

        List<Product> GetAllByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min, decimal max);

        Product GetById(int productId);

        void Add(Product product);
    }
}
