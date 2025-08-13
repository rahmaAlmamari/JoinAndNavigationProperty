using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinAndNavigationProperty.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(20)]
        public string StudentName { get; set; }
        [Required]
        [Range(0, 100)]
        public double StudentMark { get; set; }

        // One-to-many relationship with Department ...
        [ForeignKey("department")]
        public int DepartmentId { get; set; } // Foreign key property for Department ... 
        public Department department { get; set; } // Navigation property to Department class ...
        // many-to-many relationship with Course ...
        public ICollection<Course> courses { get; set; } // Navigation property to Course class
    }
}
