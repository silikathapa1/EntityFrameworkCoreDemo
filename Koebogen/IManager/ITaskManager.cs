using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Koebogen.IManager
{
    public interface ITaskManager
    {
        /// <summary>
        /// Retrieves list of all tasks
        /// </summary>
        /// <returns>A list of tasks</returns>
        List<Task> getTasks();

        /// <summary>
        /// Retrives a project for given ID
        /// </summary>
        /// <param name="taskID"></param>
        /// <returns>A task</returns>
        Task getTaskByID(int taskID);

        /// <summary>
        /// Saves task
        /// </summary>
        /// <param name="task">Task Entity</param>
        /// <returns></returns>
        bool saveTask(Task task);
    }
}
