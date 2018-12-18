using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koebogen.Models
{
    /// <summary>
    /// Represents a Task.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// The task ID.
        /// </summary>
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TaskID { get; set; }

        /// <summary>
        /// The task Name.
        /// </summary>
        public String TaskName { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        public string Description { get; set; }

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
