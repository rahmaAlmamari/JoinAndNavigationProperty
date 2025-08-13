using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinAndNavigationProperty.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; }

        // many-to-many relationship with Student ...
        public ICollection<Student> students { get; set; } // Navigation property to Student class ...
    }
}
