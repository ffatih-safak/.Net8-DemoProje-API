using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using DemoProje.Persistence.Models;
using DemoProje.Application.Interfaces.MongoDb;
using MongoDB.Bson;

namespace DemoProje.Infrastructure.MongoDb
{
    public class MongoDbService<T> : IMongoDbService<T> where T : class
    {
        private readonly IMongoDatabase _database;

        public MongoDbService(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var client = new MongoClient(mongoDbSettings.Value.ConnectionURI);
            _database = client.GetDatabase(mongoDbSettings.Value.DatabaseName);
        }

        private IMongoCollection<T> GetCollection(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }

        public async Task<List<T>> GetAsync(string collectionName)
        {
            return await GetCollection(collectionName).Find(new BsonDocument()).ToListAsync();
        }

        public async Task CreateAsync(T document, string collectionName)
        {
            await GetCollection(collectionName).InsertOneAsync(document);
        }


    }
}
