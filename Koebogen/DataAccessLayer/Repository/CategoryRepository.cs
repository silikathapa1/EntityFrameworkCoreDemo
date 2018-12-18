using Koebogen.DataAccessLayer.IRepository;
using Koebogen.IRepository;
using Koebogen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.DataAccessLayer.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private KoebogenContext context;

        public CategoryRepository(KoebogenContext context)
        {
            this.context = context;
        }

        public void AddCategory(Category category)
        {
            context.Category.Add(category);
        }

        public void DeleteCategory(int categoryID)
        {
            Category category = context.Category.Find(categoryID);
            context.Category.Remove(category);
        }

        public Category GetCategoryByID(int categoryID)
        {
            return context.Category.Find(categoryID);
        }

        public List<Category> GetCategories()
        {
            return context.Category.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            context.Entry(category).State = EntityState.Modified;
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
