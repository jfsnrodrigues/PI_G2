using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace JRod_Application.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Add(T model);

        T Update(T model);

        T Get(int modelId);

        T Get(int modelId, params Expression<Func<T, object>>[] includes);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);

        void Delete(int modelId);
    }
}
