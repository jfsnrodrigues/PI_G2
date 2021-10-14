using JRod_Application.Data.Repositories;
using JRod_Application.Models;
using Mapster;
using System.Collections.Generic;

namespace JRod_Application.Services
{
    public class TaskServices : ITaskServices
    {
        readonly ITaskRepository _taskRepository;
        readonly IUserServices _userServices;
        public TaskServices(ITaskRepository taskRepository, IUserServices userServices)
        {
            _taskRepository = taskRepository;
            _userServices = userServices;
        }

        public IEnumerable<Task> GetAll()
        {
            var allTasksRepo = _taskRepository
                .GetAll(x => x.User);

            var allTasks = allTasksRepo.Adapt<IEnumerable<Task>>();
            return allTasks;
        }

        public Task Get(int idTask)
        {
            return _taskRepository.Get(idTask, x => x.User)
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
