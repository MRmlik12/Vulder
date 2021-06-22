namespace Vulder.Search.Infrastructure.Data.Configuration
{
    public interface IMongoConfiguration
    {
        string ConnectionString { get; set; }
        string DbName { get; set; }
        string SchoolsCollectionName { get; set; }
    }
}