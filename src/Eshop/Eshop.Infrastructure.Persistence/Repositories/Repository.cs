using Eshop.Core.Application.Interfaces.Context;
using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Abstracts;
using Eshop.Infrastructure.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly ApplicationDbContext _applicationDbContext; 
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task Add(T entity)
        {
           await  _applicationDbContext.AddAsync<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
             _applicationDbContext.Entry<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public Task<List<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
            _applicationDbContext.Entry<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
