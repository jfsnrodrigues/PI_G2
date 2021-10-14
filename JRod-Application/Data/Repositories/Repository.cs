using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace JRod_Application.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly Context _context;
        public Repository(Context context)
        {
            _context = context;
        }

        public T Add(T model)
        {
            _context.Set<T>().Add(model);
            _context.SaveChanges();

            return model;
        }

        public void Delete(int modelId)
        {
            T model = Get(modelId);
            _context.Set<T>().Remove(model);
            _context.SaveChanges();
        }

        public T Get(int modelId)
           => _context.Set<T>().Find(modelId);

        public T Get(int modelId, params Expression<Func<T, object>>[] includes)
        {
            DbSet<T> dbSet = _context.Set<T>();

            foreach (var include in includes)
                dbSet.Include(include);

            return dbSet.Find(modelId);
        }

        public IEnumerable<T> GetAll()
            => _context.Set<T>().ToList();

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            DbSet<T> dbSet = _context.Set<T>();

            IEnumerable<T> query = null;

            foreach (var include in includes)
                query = dbSet.Include(include);

            return query ?? dbSet;
        }

        public T Update(T model)
        {
            var entry = _context.Entry(model);
            entry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return model;
        }
    }
}
