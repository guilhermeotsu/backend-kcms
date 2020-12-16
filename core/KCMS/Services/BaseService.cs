using KCMS.Configuration;
using KCMS.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KCMS.Services
{
    public abstract class BaseService<T> where T : Entity
    {
        protected readonly IMongoCollection<T> _mongoColletion;
        public BaseService(IKCMSDatabaseSettings settings, string collectionName)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _mongoColletion = database.GetCollection<T>(collectionName);
        }
        public virtual List<T> Get() => _mongoColletion.Find(p => true).ToList();
        public virtual T Get(string id) => _mongoColletion.Find(p => p.Id == id).FirstOrDefault();
        public List<T> Get(Expression<Func<T, bool>> expression) => _mongoColletion.Find(expression).ToList();
        public T Create(T entity)
        {
            _mongoColletion.InsertOne(entity);
            return entity;
        }
        public void Update(string id, T entity) => _mongoColletion.ReplaceOne(p => p.Id == id, entity);
        public void Remove(string id) => _mongoColletion.DeleteOne(p => p.Id == id);
        public void Remove(T entity) => _mongoColletion.DeleteOne(p => p.Id == entity.Id);
    }
}
