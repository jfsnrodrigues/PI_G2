using System.Collections.Generic;

namespace JRod_Application.Data.Repositories
{
    public interface ITaskRepository : IRepository<DataModels.Task>
    {
        IEnumerable<DataModels.Task> GetByUser(int userId);
    }
}
