using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp;

namespace GatasdaManu.Repository.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly IMongoCollection<T> Collection;
        protected MongoClientSettings MongoClientSettings;
        private readonly IMongoDatabase _mongoDatabase;
        
        protected RepositoryBase(string connectionString, string collectionName) //O construtor é responsável por fazer a inicialização da classe junto com alguns parametros.
        {
            MongoClientSettings = MongoClientSettings.FromConnectionString(connectionString);
            _mongoDatabase = new MongoClient(MongoClientSettings).GetDatabase(MongoUrl.Create(connectionString).DatabaseName);
            Collection = _mongoDatabase.GetCollection<T>(collectionName);
        }
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            var find = Collection.Find(expression);
            var result = await find.ToListAsync();
            Console.WriteLine($"Query:{find.ToString()}");
            return result;
        }
    }
}
