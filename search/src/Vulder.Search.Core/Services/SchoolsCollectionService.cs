using System.Collections.Generic;
using System.Threading.Tasks;
using Vulder.Search.Core.Interfaces;
using Vulder.Search.Core.ProjectAggregate.School;

namespace Vulder.Search.Core.Services
{
    public class SchoolsCollectionService : ISchoolCollectionService
    {
        private readonly ISchoolRepository _repository;
        
        public SchoolsCollectionService(ISchoolRepository repository)
        {
            _repository = repository;
        }
        
        public Task<List<School>> Get(string input)
            => _repository.Get(input);

        public Task Create(School school)
            => _repository.Create(school);
    }
}