using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinAndNavigationProperty.Models
{
    public class Manager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManagerId { get; set; }
        [Required]
        [MaxLength(20)]
        public string ManagerName { get; set; }

        // One-to-One relationship with Department
        [ForeignKey("department")]
        public int DepartmentId { get; set; } // Foreign key property for Department
        public Department department { get; set; } // Navigation property to Department class
    }
}
