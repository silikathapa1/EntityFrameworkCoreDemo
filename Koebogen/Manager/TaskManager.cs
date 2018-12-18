using Koebogen.DataAccessLayer.IRepository;
using Koebogen.DataAccessLayer.Repository;
using Koebogen.IManager;
using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Koebogen.Manager
{
    public class TaskManager : ITaskManager
    {
        private ITaskRepository taskRepository = new TaskRepository();

        public Task getTaskByID(int taskID)
        {
            throw new NotImplementedException();
        }

        public List<Task> getTasks()
        {
            return taskRepository.GetTasks();
        }

        public bool saveTask(Task task)
        {
            taskRepository.AddTask(task);
            return true;
        }
    }
}
