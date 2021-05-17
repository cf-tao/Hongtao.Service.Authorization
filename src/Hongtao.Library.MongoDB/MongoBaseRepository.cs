using Hongtao.Library.MongoDB.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hongtao.Library.MongoDB
{
    public class MongoBaseRepository<T> : IMongoBaseRepository<T> where T : MongoBase
    {
        private readonly IMongoCollection<T> collection;

        public MongoBaseRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            collection = database.GetCollection<T>(settings.CollectionName);
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return (await collection.FindAsync(entity => true)).ToList();
        }

        public async Task<T> GetAsync(string id)
        {
            return (await collection.FindAsync<T>(entity => entity.Id == id)).FirstOrDefault();
        }

        public async Task<T> CreateAsync(T entity)
        {
            if(string.IsNullOrWhiteSpace(entity.Id))
            {
                entity.Id = Guid.NewGuid().ToString();
            }
            await collection.InsertOneAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(string id, T entityIn)
        {
            await collection.ReplaceOneAsync(book => book.Id == id, entityIn);
        }

        public async Task RemoveAsync(T entityIn)
        {
            await collection.DeleteOneAsync(entity => entity.Id == entityIn.Id);
        }

        public async Task RemoveAsync(string id)
        {
            await collection.DeleteOneAsync(entity => entity.Id == id);
        }
    }
}