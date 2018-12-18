using Koebogen.IRepository;
using Koebogen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.DataAccessLayer.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly KoebogenContext context = new KoebogenContext();

        public void DeleteProject(int projectID)
        {
            Project project = context.Project.Find(projectID);
            context.Project.Remove(project);
        }

        public Project GetProjectByID(int projectId)
        {
            var project = context.Project.Find(projectId);
            project.Groups = context.Group.Where(x => x.ProjectID == project.ProjectID).ToList();
            return project;
        }

        public List<Project> GetProjects()
        {
            return context.Project.ToList();
        }

        public void AddProject(Project project)
        {
            context.Project.Add(project);
            context.SaveChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            context.Entry(project).State = EntityState.Modified;
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
