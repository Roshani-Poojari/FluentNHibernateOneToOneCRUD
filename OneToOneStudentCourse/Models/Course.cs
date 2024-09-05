using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneToOneStudentCourse.Models
{
    public class Course
    {
        public virtual int Id { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "Course name can only contain alphabets, numbers, and spaces.")]
        public virtual string Name { get; set; }

        [Required]
        [Range(1,int.MaxValue)]
        public virtual int Duration { get; set; }
        public virtual Student Student { get; set; }
    }
}