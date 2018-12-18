using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Koebogen.DataAccessLayer.IRepository
{
    interface IGroupRepository : IDisposable
    {
        /// <summary>
        /// Retrieves list of all groups
        /// </summary>
        /// <returns>A list of groups</returns>
        List<Group> GetGroups();

        /// <summary>
        /// Retrieves a group by group ID
        /// </summary>
        /// <returns>A Group</returns>
        Group GetGroupByID(int groupId);

        /// <summary>
        /// Adds group
        /// </summary>
        /// <param name="Group">Group entity</param>
        void AddGroup(Group group);

        /// <summary>
        /// Deletes group by group ID
        /// </summary>
        /// <param name="GroupID"></param>
        void DeleteGroup(int groupID);

        /// <summary>
        /// Updates Group
        /// </summary>
        /// <param name="Group"></param>
        void UpdateGroup(Group group);

        /// <summary>
        /// Save Group
        /// </summary>
        void Save();
    }
}