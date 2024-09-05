using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using OneToOneStudentCourse.Models;

namespace OneToOneStudentCourse.Mappings
{
    public class CourseMap:ClassMap<Course>
    {
        public CourseMap()
        {
            Table("Courses");
            Id(c => c.Id).GeneratedBy.Identity();
            Map(c => c.Name);
            Map(c => c.Duration);
            References(c => c.Student).Column("student_id").Unique().Cascade.None();
        }
    }
}