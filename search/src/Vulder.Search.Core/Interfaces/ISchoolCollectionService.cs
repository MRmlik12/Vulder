using System.Collections.Generic;
using System.Threading.Tasks;
using Nest;
using Vulder.Search.Infrastructure.Data.Entities;

namespace Vulder.Search.Core.Interfaces
{
    public interface ISchoolCollectionService
    {
        public Task<ISearchResponse<School>> Get(string input);
        public void Create(School school);
    }
}