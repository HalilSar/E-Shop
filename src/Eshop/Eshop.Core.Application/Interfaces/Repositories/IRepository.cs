using Eshop.Core.Domain.Abstracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T:BaseEntity, new()
    {

        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<List<T>> Get();
        Task<T> GetById(int id);
    }
}
