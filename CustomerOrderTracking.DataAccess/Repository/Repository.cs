using CustomerOrderTracking.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderTracking.DataAccess.Repository
{
   
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CustomerOrderTrackingDbContext _db;
        private readonly DbSet<T> _dbSet;

        public Repository(CustomerOrderTrackingDbContext db, DbSet<T> dbSet)
        {
            _db = db;
            _dbSet = dbSet;
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return (await _dbSet.FindAsync(id))!;
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
