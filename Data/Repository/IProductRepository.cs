using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductbyProductName(string name);

        void UpdateProduct(Product product);

        void DeleteProduct(string name);

        void CreateProduct(Product product);

        IEnumerable<Product> SearchProductFilter(Product product);
    }
}