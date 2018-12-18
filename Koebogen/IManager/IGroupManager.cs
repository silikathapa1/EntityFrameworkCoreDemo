using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.IManager
{
    interface IGroupManager
    {
        /// <summary>
        /// Retrieves list of all groups
        /// </summary>
        /// <returns>A list of groups</returns>
        List<Group> getGroups();

        /// <summary>
        /// Retrives a Group for given ID
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns>A Group</returns>
        Group getGroupByID(int groupID);

        /// <summary>
        /// Saves Group
        /// </summary>
        /// <param name="group">Group Entity</param>
        /// <returns></returns>
        bool saveGroup(Group group);
    }
}
