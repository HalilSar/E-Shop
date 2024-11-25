using Eshop.Core.Application.Interfaces.Context;
using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Abstracts;
using Eshop.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected readonly ApplicationDbContext _applicationDbContext; 
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
	// Parameter T entity  where T : BaseEntity, new()
        public async Task Add(T entity)
        {
           await  _applicationDbContext.AddAsync<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
        // Parameter T entity  where T : BaseEntity, new()
        public async Task Delete(T entity)
        {
             _applicationDbContext.Remove<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
        // Return List<T>   where T : BaseEntity, new()
        public async Task<List<T>> Get()
        {
           return await _applicationDbContext.Set<T>().ToListAsync();
        }
  // Return T where T : BaseEntity, new()
  // Parameter int id
        public async Task<T> GetById(int id)
        {
            return await _applicationDbContext.FindAsync<T>(id);
        }
        // Parameter T entity  where T : BaseEntity, new()
        public async Task Update(T entity)
        {
            _applicationDbContext.Entry<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
