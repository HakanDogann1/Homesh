using Homesh.DataAccessLayer.Abstract;
using Homesh.DataAccessLayer.Settings.Abstract;
using Homesh.EntityLayer.Abstract;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IMongoEntity
    {
        private readonly IMongoCollection<T> _mongoCollection;
        public GenericRepository(IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _mongoCollection = database.GetCollection<T>(typeof(T).Name.ToLowerInvariant());    
        }
        public void Add(T entity)
        {
            _mongoCollection.InsertOne(entity);
        }

        public void Delete(string id)
        {
            _mongoCollection.FindOneAndDelete(x=>x.ID==id);
        }

        public List<T> GetAll()
        {
            return _mongoCollection.AsQueryable().ToList();
        }

        public T GetById(string id)
        {
            return _mongoCollection.Find<T>(x=>x.ID==id).FirstOrDefault();
        }

        public void Update(T entity)
        {
            _mongoCollection.FindOneAndReplace<T>(x=>x.ID==entity.ID, entity);
        }
    }
}
