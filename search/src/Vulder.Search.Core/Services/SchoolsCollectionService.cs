using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nest;
using Vulder.Search.Core.Interfaces;
using Vulder.Search.Infrastructure.Data;
using Vulder.Search.Infrastructure.Data.Config;
using Vulder.Search.Infrastructure.Data.Entities;

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

        public async Task<ISearchResponse<School>> Get(string input) => await _client.SearchAsync<School>(s => s
            .Index("schools")
            .From(0)
            .Size(10)
            .Query(q => q.Term(t => t.Name, input) ||
                        q.Match(mq => mq.Field(f => f.Name).Query("nest")))
        );

        public async void Create(School school)
        {
            await _client.IndexAsync(school, idx => idx.Index("Schools"));
        }
    }
}