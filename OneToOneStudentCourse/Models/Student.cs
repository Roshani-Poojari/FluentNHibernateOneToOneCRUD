using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneToOneStudentCourse.Models
{
    public class Student
    {
        public virtual int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name can only contain alphabets.")]
        public virtual string Name { get; set; }

        [Required]
        [Range(16,25)]
        public virtual int Age { get; set; }

        [Required]
        [EmailAddress]
        public virtual string Email { get; set; }
        public virtual Course Course { get; set; }
    }
}