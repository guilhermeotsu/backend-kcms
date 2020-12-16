using KCMS.Configuration;
using KCMS.Interfaces;
using KCMS.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KCMS.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        private readonly IMongoCollection<Product> _productCollection;
        public CategoryService(IKCMSDatabaseSettings settings) 
            : base(settings, CollectionNames.Category)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _productCollection = database.GetCollection<Product>(CollectionNames.Products);
        }

        public List<Product> GetProducts(string id) => _productCollection.Find(p => p.CategoryId == id).ToList();
    }
}
