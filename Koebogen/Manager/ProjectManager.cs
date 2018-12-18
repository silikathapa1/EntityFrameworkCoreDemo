using Koebogen.DataAccessLayer.Repository;
using Koebogen.IManager;
using Koebogen.IRepository;
using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.Manager
{
    public class ProjectManager : IProjectManager
    {
        private IProjectRepository projectRepository = new ProjectRepository();

        /// <summary>
        /// Retrieves list of all projects
        /// </summary>
        /// <returns>A list of projects</returns>
        public Project getProjectByID(int projectID)
        {
            return projectRepository.GetProjectByID(projectID);
        }

        /// <summary>
        /// Retrives a project for given ID
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns>A project</returns>
        public List<Project> getProjects()
        {
            return projectRepository.GetProjects();
        }

        /// <summary>
        /// Saves project
        /// </summary>
        /// <param name="project">Project Entity</param>
        /// <returns></returns>
        public bool saveProject(Project project)
        {
            projectRepository.AddProject(project);
            return true;
        }
    }
}
