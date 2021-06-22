using System.Collections.Generic;
using System.Threading.Tasks;
using Vulder.Search.Core.ProjectAggregate.School;

namespace Vulder.Search.Core.Interfaces
{
    public interface ISchoolRepository
    {
        Task Create(School school);
        Task Update(string id, School school);
        Task<List<School>> Get(string name);
    }
}