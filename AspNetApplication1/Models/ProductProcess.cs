using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApplication1.Models
{
    class ProductProcess
    {
        ProductDAO dao;
        public ProductProcess()
        {
            dao = new ProductDAO();
        }
        public List<Product> GetProducts(string criteria)
        {
            return dao.GetProducts(criteria);
        }
        public Product GetProduct(int ProductId)
        {
            return dao.GetProduct(ProductId);
        }
        public void Createproduct(Product item)//Add the new Product
        {
            dao.Createproduct(item);
        }
        public void UpdateProduct(Product item)
        {
            dao.UpdateProduct(item);
        }
    }
}
