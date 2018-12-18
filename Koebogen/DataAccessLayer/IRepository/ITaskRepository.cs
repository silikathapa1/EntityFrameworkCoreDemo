using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Koebogen.DataAccessLayer.IRepository
{
    interface ITaskRepository : IDisposable
    {
        /// <summary>
        /// Retrieves list of all tasks
        /// </summary>
        /// <returns>A list of tasks</returns>
        List<Task> GetTasks();

        /// <summary>
        /// Retrieves a task by task ID
        /// </summary>
        /// <returns>A task</returns>
        Task GetTaskByID(int taskId);

        /// <summary>
        /// Adds task
        /// </summary>
        /// <param name="task">Task entity</param>
        void AddTask(Task task);

        /// <summary>
        /// Deletes task by task ID
        /// </summary>
        /// <param name="taskID"></param>
        void DeleteTask(int taskID);

        /// <summary>
        /// Updates task
        /// </summary>
        /// <param name="task"></param>
        void UpdateTask(Task task);

        /// <summary>
        /// Save task
        /// </summary>
        void Save();
    }
}
