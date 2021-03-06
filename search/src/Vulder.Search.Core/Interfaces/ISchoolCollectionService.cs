using System.Collections.Generic;
using System.Threading.Tasks;
using Vulder.Search.Core.ProjectAggregate.School;

namespace Vulder.Search.Core.Interfaces
{
    public interface ISchoolCollectionService
    {
        public Task<List<School>> Get(string input);
        public Task Create(School school);
    }
}