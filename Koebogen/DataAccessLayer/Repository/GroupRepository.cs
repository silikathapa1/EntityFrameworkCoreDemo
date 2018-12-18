using Koebogen.DataAccessLayer.IRepository;
using Koebogen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.DataAccessLayer.Repository
{
    public class GroupRepository : IGroupRepository
    {
        private readonly KoebogenContext context = new KoebogenContext();

        public void AddGroup(Models.Group group)
        {
            context.Group.Add(group);
            context.SaveChanges();
        }

        public void DeleteGroup(int groupID)
        {
            Group group = context.Group.Find(groupID);
            context.Group.Remove(group);
        }

        public Group GetGroupByID(int groupId)
        {
            return context.Group.Find(groupId);
        }

        public List<Group> GetGroups()
        {
            return context.Group.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateGroup(Group group)
        {
            context.Entry(group).State = EntityState.Modified;
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
