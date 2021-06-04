using System.Threading.Tasks;

namespace Vulder.Search.SharedKernel.Interface
{
    public interface IRepository
    {
        Task<T> AddAsync<T>(T entity) where T : BaseEntity, IAggregateRoot;
        Task<T> GetByNameAsync<T>(string name) where T : BaseEntity, IAggregateRoot;
        Task UpdateAsync<T>(T entity) where T : BaseEntity, IAggregateRoot;
        Task DeleteAsync<T>(T entity) where T : BaseEntity, IAggregateRoot;
    }
}