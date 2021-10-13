using JRod_Application.Data.Repositories;
using JRod_Application.Models;
using Mapster;
using System.Collections.Generic;

namespace JRod_Application.Services
{
    public class TaskServices : ITaskServices
    {
        readonly ITaskRepository _taskRepository;
        public TaskServices(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<Task> GetAll()
        {
            return _taskRepository.GetAll()
                .Adapt<IEnumerable<Task>>();
        }

        public Task Get(int idTask)
        {
            return _taskRepository.Get(idTask)
                .Adapt<Task>();
        }

        public IEnumerable<Task> GetByUser(int userId)
        {
            return _taskRepository.GetByUser(userId)
                .Adapt<IEnumerable<Task>>();
        }

        public Task Update(Task task)
        {
            Data.DataModels.Task taskDb = _taskRepository.Get(task.TaskId);

            task.Adapt(taskDb);

            return _taskRepository.Update(taskDb).Adapt<Task>();
        }

        public Task Add(Task task)
        {
            return _taskRepository
                .Add(task.Adapt<Data.DataModels.Task>())
                .Adapt<Task>();
        }

        public void Delete(int taskId)
        {
            _taskRepository.Delete(taskId);
        }
    }
}
