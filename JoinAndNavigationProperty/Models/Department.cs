using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinAndNavigationProperty.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string DepartmentName { get; set; }

        //One-to-many relationship with Student ...
        public ICollection<Student> students { get; set; } // Navigation property to Student class ...
        //One-to-One relationship with Manager ...
        public Manager manager { get; set; } // Navigation property to Manager class ...
    }
}
