using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webappsdemo.Models
{
    public class SqlRepository : IProductRepo
    {
        private readonly Appcontext _appcontext;
        public SqlRepository(Appcontext appcontext)
        {
            this._appcontext = appcontext;
        }
        public Products AddProducts(Products data)
        {
            _appcontext.Products.Add(data);
            _appcontext.SaveChanges();
            return (data);
        }

        public Products DeleteProducts(int  id)
        {
            Products proddata = _appcontext.Products.Find(id);
            if (proddata!=null)
            {
                _appcontext.Products.Remove(proddata);
                _appcontext.SaveChanges();
            }
            return proddata;
        }

        public Products DeleteProducts(Products data)
        {
            throw new NotImplementedException();
        }

        public List<Products> FetchProductInfo()
        {
            throw new NotImplementedException();
        }

        public string GetProductInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Products GetProductInfodata(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Products UpdateProducts(Products data)
        {
            var proddata = _appcontext.Products.Attach(data);
            proddata.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appcontext.SaveChanges();
            return (data);
        }
    }
}
