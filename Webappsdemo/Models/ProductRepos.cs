using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webappsdemo.Models
{
    public class ProductRepos : IProductRepo
    {
        private List<Products> _productRepo;
        public ProductRepos()
        {
            //_productRepo = new List<prou({ new Products { ProductId = 1, ProductName = "Cashwnet" }, new Products{ });
            _productRepo = new List<Products>()
            {  new Products{ ProductId=1,ProductName="Product A"},
               new Products{ ProductId=2,ProductName="Product B"},
               new Products{ ProductId=3,ProductName="Product C"},
               new Products{ ProductId=4,ProductName="Product D"},
               new Products{ ProductId=5,ProductName="Product E"},
               new Products{ ProductId=6,ProductName="Product F"},
            };
        }
        public List<Products>  FetchProductInfo()
        {
           return (_productRepo.OrderBy(a=>a.ProductId).ToList());
        }

        public string GetProductInfo(int id)
        {
           return  _productRepo.FirstOrDefault(obj => obj.ProductId == id).ProductName;
        }

        public Products GetProductInfodata(int id)
        {
            var mydata = (Products)_productRepo.FirstOrDefault(obj => obj.ProductId == id);
            return (mydata);
        }
        public void UpdateProductInfo(int id)
        {
           // return _productRepo.Select();
        }
    }
}
