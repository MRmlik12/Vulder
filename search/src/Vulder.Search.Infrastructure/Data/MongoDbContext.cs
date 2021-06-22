using MongoDB.Driver;
using Vulder.Search.Core.ProjectAggregate.School;
using Vulder.Search.Infrastructure.Data.Configuration;

namespace Vulder.Search.Infrastructure.Data
{
    public class MongoDbContext : School
    {
        private readonly MongoClient _mongoClient;
        private readonly IMongoDatabase _mongoDatabase;
        
        public IMongoCollection<School> Schools { get; }

        public MongoDbContext(IMongoConfiguration configuration)
        {
            _mongoClient = new MongoClient(configuration.ConnectionString);
            _mongoDatabase = _mongoClient.GetDatabase(configuration.DbName);
            Schools = _mongoDatabase.GetCollection<School>(configuration.SchoolsCollectionName);
        }
    }
}