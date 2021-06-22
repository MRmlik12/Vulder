using MongoDB.Driver;
using Vulder.Search.Core.ProjectAggregate.School;

namespace Vulder.Search.Infrastructure.Data
{
    public interface IMongoDbContext
    {
        public IMongoCollection<School> Schools { get; }
    }
}