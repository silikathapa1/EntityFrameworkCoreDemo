using Koebogen.DataAccessLayer.IRepository;
using Koebogen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Koebogen.DataAccessLayer.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly KoebogenContext context = new KoebogenContext();

        public void AddTask(Task task)
        {
            context.Task.Add(task);
            context.SaveChanges();
        }

        public void DeleteTask(int taskID)
        {
            Task task = context.Task.Find(taskID);
            context.Task.Remove(task);
        }

        public Task GetTaskByID(int taskId)
        {
            return context.Task.Find(taskId);
        }

        public List<Task> GetTasks()
        {
            return context.Task.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            context.Entry(task).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
