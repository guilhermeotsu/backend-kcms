using KCMS.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KCMS.Interfaces
{
    public interface ICategoryService
    {
        public List<Category> Get();
        public Category Get(string id);
        public List<Category> Get(Expression<Func<Category, bool>> expression);
        public Category Create(Category entity);
        public void Update(string id, Category entity);
        public void Remove(string id);
        public void Remove(Category entity);
        public List<Product> GetProducts(string id);
    }
}
