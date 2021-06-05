using System;
using System.Threading.Tasks;
using Nest;
using Vulder.Search.Core.Interfaces;
using Vulder.Search.Core.ProjectAggregate.School;
using Vulder.Search.Infrastructure.Data.Config;

namespace Vulder.Search.Core.Services
{
    public class SchoolsCollectionService : ISchoolCollectionService
    {
        private readonly ElasticClient _client;

        public SchoolsCollectionService(IElasticsearchConfiguration configuration)
        {
            var node = new ConnectionSettings(new Uri(configuration.Host));
            _client = new ElasticClient(node);
        }

        public async Task<ISearchResponse<School>> Get(string input)
            => await _client.SearchAsync<School>(s => s
                .Index("schools")
                .From(0)
                .Size(10)
                .Query(q => q.Term(t => t.Name, input) ||
                            q.Match(mq => mq.Field(f => f.Name).Query(input)))
            );

        public async Task<School> Create(School school)
        {
            await _client.IndexAsync(school, idx => idx.Index("Schools"));
            return school;
        }

        public async Task Delete(string id)
        {
            await _client.DeleteAsync<School>(id);
        }
    }
}