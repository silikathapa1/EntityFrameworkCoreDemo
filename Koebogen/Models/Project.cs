using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Koebogen.Models
{
    /// <summary>
    /// Represents a Project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// The Project ID.
        /// </summary>
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        /// <summary>
        /// The Project Name.
        /// </summary>
        public String ProjectName { get; set; }

        ///<summary>
        ///The list of group
        ///</summary>
        public virtual ICollection<Group> Groups { get; set; }
       
    }
}
