using KCMS.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KCMS.Interfaces
{
    public interface IProductService
    {
        public List<Product> Get();
        public Product Get(string id);
        public List<Product> Get(Expression<Func<Product, bool>> expression);
        public Product Create(Product entity);
        public void Update(string id, Product entity);
        public void Remove(string id);
        public void Remove(Product entity);
    }
}
