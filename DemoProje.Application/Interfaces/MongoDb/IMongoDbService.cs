using DemoProje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Interfaces.MongoDb
{
    public interface IMongoDbService<T> where T : class
    {
        Task<List<T>> GetAsync(string collectionName);
        Task CreateAsync(T document, string collectionName);
    }
}
