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
             _applicationDbContext.Remove<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<T>> Get()
        {
           return await _applicationDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _applicationDbContext.FindAsync<T>(id);
        }

        public async Task Update(T entity)
        {
            _applicationDbContext.Entry<T>(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
