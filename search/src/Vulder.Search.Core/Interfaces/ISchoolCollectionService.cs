using System.Threading.Tasks;
using Nest;
using Vulder.Search.Core.ProjectAggregate.School;

namespace Vulder.Search.Core.Interfaces
{
    public interface ISchoolCollectionService
    {
        public Task<ISearchResponse<School>> Get(string input);
        public Task<School> Create(School school);
        public Task Delete(string id);
    }
}