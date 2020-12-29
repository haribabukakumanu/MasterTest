using MasterTest.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterTest.Services
{
    public class RepositoryService<T, TContext> : IRepository<T>
        where T : class
        where TContext : DbContext
    {
        public readonly TContext _db;

        public RepositoryService(TContext db)
        {
            _db = db;
        }

        public async Task<T> Add(T entity)
        {
            _db.Set<T>().Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _db.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Get(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
