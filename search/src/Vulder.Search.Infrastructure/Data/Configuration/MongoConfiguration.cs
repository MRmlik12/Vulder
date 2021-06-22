namespace Vulder.Search.Infrastructure.Data.Configuration
{
    public class MongoConfiguration : IMongoConfiguration
    {
        public string ConnectionString { get; set; }
        public string DbName { get; set; }
        public string SchoolsCollectionName { get; set; }
    }
}