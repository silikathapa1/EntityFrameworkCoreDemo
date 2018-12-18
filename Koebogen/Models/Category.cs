using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koebogen.Models
{
    public class Category
    {
        /// <summary>
        /// The Category ID.
        /// </summary>
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        /// <summary>
        /// The Category Name.
        /// </summary>
        public String CategoryName { get; set; }

        /// <summary>
        /// The location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        public int GroupID { get; set; }

        /// <summary>
        /// The group.
        /// </summary>
        public Group Group { get; set; }
    }
}
