using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Koebogen.Models;
using Koebogen.IManager;
using Koebogen.Manager;

namespace Koebogen.Controllers
{
    [Produces("application/json")]
    [Route("api/Tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITaskManager taskManager = new TaskManager();

        // GET: api/Tasks
        [HttpGet]
        public List<Task> getTasks()
        {
            return taskManager.getTasks();
        }

        // POST: api/Tasks
        [HttpPost]
        public string Post([FromBody] Task task)
        {
            return taskManager.saveTask(task).ToString();
        }
    }
}