using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webappsdemo.Models
{
   public interface IProductRepo
    {
        string GetProductInfo(int id);
        Products GetProductInfodata(int id);
        void UpdateProductInfo(int id);
        List<Products> FetchProductInfo();
    }
}
