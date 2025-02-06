using Eshop.Core.Domain.Abstracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T:BaseEntity, new()
    {
        // Parameter : T entity
        Task Add(T entity);

	// Parameter : T entity
        Task Delete(T entity);

	// Parameter : T entity
        Task Update(T entity);

	// Return : List<T> entity
        Task<List<T>> Get();

	// Return    : T
	// Parameter : int id
        Task<T> GetById(int id);
    }
}
