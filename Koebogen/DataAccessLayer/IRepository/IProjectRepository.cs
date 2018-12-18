using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.IRepository
{
    interface IProjectRepository: IDisposable
    {
        /// <summary>
        /// Retrieves list of all projects
        /// </summary>
        /// <returns>A list of projects</returns>
        List<Project> GetProjects();

        /// <summary>
        /// Retrieves a project by project ID
        /// </summary>
        /// <returns>A project</returns>
        Project GetProjectByID(int projectId);

        /// <summary>
        /// Adds project
        /// </summary>
        /// <param name="project">Project entity</param>
        void AddProject(Project project);

        /// <summary>
        /// Deletes project by project ID
        /// </summary>
        /// <param name="projectID"></param>
        void DeleteProject(int projectID);

        /// <summary>
        /// Updates project
        /// </summary>
        /// <param name="project"></param>
        void UpdateProject(Project project);

        /// <summary>
        /// Save project
        /// </summary>
        void Save();
    }
}
