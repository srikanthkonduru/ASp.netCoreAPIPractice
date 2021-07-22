using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIPractice1.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage ="Employe Name shoulbr Grater then 2 Char")]
        [MaxLength(150, ErrorMessage = "Employe Name shoulbr Less then 150 Char")]
        public string StudentName { get; set; }
        [Required]
        [EmailAddress]
        [MinLength(2, ErrorMessage = "Employe Email shoulbr Grater then 2 Char")]
        [MaxLength(150, ErrorMessage = "Employe Email shoulbr Less then 150 Char")]
        public string StudentEmail { get; set; }
        public string Gender { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Phone shoud be 10 Digits")]
        [MaxLength(10, ErrorMessage = "Phone shoud be 10 Digits")]
        public string Phone { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }


    }
}
