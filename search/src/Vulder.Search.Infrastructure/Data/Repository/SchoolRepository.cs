using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Vulder.Search.Core.Interfaces;
using Vulder.Search.Core.ProjectAggregate.School;

namespace Vulder.Search.Infrastructure.Data.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly MongoDbContext _context;
        
        public SchoolRepository(MongoDbContext context)
        {
            _context = context;
        }

        public async Task Create(School school) 
            => await _context.Schools.InsertOneAsync(school);

        public async Task Update(string id, School school)
            => await _context.Schools.ReplaceOneAsync(s => s.Id == id, school);

        public async Task<List<School>> Get(string name)
            => await _context.Schools.Find(s => s.Name == name).Limit(10).ToListAsync();
    }
}