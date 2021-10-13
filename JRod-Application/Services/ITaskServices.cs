using JRod_Application.Models;
using System.Collections.Generic;

namespace JRod_Application.Services
{
    public interface ITaskServices
    {
        IEnumerable<Task> GetAll();
        Task Get(int idTask);
        Task Update(Task task);
        Task Add(Task task);
        void Delete(int taskId);
    }
}