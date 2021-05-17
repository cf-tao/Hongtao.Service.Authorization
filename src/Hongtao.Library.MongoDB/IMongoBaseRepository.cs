using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hongtao.Library.MongoDB
{
    public interface IMongoBaseRepository<T>
    {
        Task<IList<T>> GetAllAsync();

        Task<T> GetAsync(string id);

        Task<T> CreateAsync(T entity);

        Task UpdateAsync(string id, T entityIn);

        Task RemoveAsync(T entityIn);

        Task RemoveAsync(string id);
    }
}