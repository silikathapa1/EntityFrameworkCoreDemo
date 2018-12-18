using Koebogen.DataAccessLayer.IRepository;
using Koebogen.DataAccessLayer.Repository;
using Koebogen.IManager;
using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Koebogen.Manager
{
    public class GroupManager : IGroupManager
    {
        private IGroupRepository groupRepository = new GroupRepository();

        public Group getGroupByID(int groupID)
        {
            throw new NotImplementedException();
        }

        public List<Group> getGroups()
        {
            return groupRepository.GetGroups();
        }

        public bool saveGroup(Group group)
        {
            groupRepository.AddGroup(group);
            return true;
        }
    }
}
