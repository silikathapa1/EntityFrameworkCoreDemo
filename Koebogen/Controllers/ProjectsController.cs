using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koebogen.IManager;
using Koebogen.Manager;
using Koebogen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Koebogen.Controllers
{
    [Produces("application/json")]
    [Route("api/Projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IProjectManager projectManager = new ProjectManager();

        // GET: api/Projects
        [HttpGet]
        public List<Project> getProjects()
        {
            return projectManager.getProjects();
        }

        // GET: api/Projects/5
        [HttpGet("{id}", Name = "Get")]
        public Project getProjectByID(int id)
        {
            return projectManager.getProjectByID(id);
        }

        // POST: api/Projects
        [HttpPost]
        public string Post([FromBody] Project project)
        {
            return projectManager.saveProject(project).ToString();
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
