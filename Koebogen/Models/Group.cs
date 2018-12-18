using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.Models
{
    /// <summary>
    /// Represents a Group.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// The group ID.
        /// </summary>
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int GroupID { get; set; }

        /// <summary>
        /// The group name.
        /// </summary>
        public String GroupName { get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        public int ProjectID { get; set; }

        /// <summary>
        /// The project.
        /// </summary>
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        ///<summary>
        ///The list of category
        ///</summary>
        public virtual ICollection<Category> Categories { get; set; }
       
        ///<summary>
        ///The list of task.
        ///</summary>
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
