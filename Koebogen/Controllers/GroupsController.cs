using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Koebogen.Models;
using Koebogen.Manager;
using Koebogen.IManager;

namespace Koebogen.Controllers
{
    [Produces("application/json")]
    [Route("api/Groups")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private IGroupManager groupManager = new GroupManager();

        // GET: api/Groups
        [HttpGet]
        public IEnumerable<Group> GetGroup()
        {
            return groupManager.getGroups();
        }

        // POST: api/Groups
        [HttpPost]
        public string Post([FromBody] Group group)
        {
            return groupManager.saveGroup(group).ToString();
        }

    }
}