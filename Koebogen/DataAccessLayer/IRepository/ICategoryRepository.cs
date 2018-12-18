using Koebogen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.IRepository
{
    interface ICategoryRepository : IDisposable
    {
        /// <summary>
        /// Retrieves list of all categories
        /// </summary>
        /// <returns>A list of categories</returns>
        List<Category> GetCategories();

        /// <summary>
        /// Retrieves a category by category ID
        /// </summary>
        /// <returns>A category</returns>
        Category GetCategoryByID(int categoryId);

        /// <summary>
        /// Adds category
        /// </summary>
        /// <param name="category">Category entity</param>
        void AddCategory(Category category);

        /// <summary>
        /// Deletes category by category ID
        /// </summary>
        /// <param name="categoryID"></param>
        void DeleteCategory(int categoryID);

        /// <summary>
        /// Updates category
        /// </summary>
        /// <param name="category"></param>
        void UpdateCategory(Category category);

        /// <summary>
        /// Save category
        /// </summary>
        void Save();
    }
}
