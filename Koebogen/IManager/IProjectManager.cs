using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.IManager
{
    public interface IProjectManager
    {
        /// <summary>
        /// Retrieves list of all projects
        /// </summary>
        /// <returns>A list of projects</returns>
        List<Project> getProjects();

        /// <summary>
        /// Retrives a project for given ID
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns>A project</returns>
        Project getProjectByID(int projectID);

        /// <summary>
        /// Saves project
        /// </summary>
        /// <param name="project">Project Entity</param>
        /// <returns></returns>
        bool saveProject(Project project);
    }
}
