using JRod_Application.Data.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace JRod_Application.Data.Repositories
{
    public class TaskRepository : Repository<DataModels.Task>, ITaskRepository
    {
        public TaskRepository(Context context)
            : base(context)
        { }

        public IEnumerable<Task> GetByUser(int userId)
        {
            return _context.Tasks.Where(x => x.User.UserId == userId).ToList();
        }
    }
}
