using Eshop.Core.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T:BaseEntity, new()
    {

        Task Add(T entity);
        Task Delete(T entity);
        Task<List<T>> Get();
        Task<T> GetById(int id);
    }
}
