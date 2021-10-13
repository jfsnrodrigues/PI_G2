using System.Collections.Generic;

namespace JRod_Application.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Add(T model);

        T Update(T model);

        T Get(int modelId);

        IEnumerable<T> GetAll();

        void Delete(int modelId);
    }
}
