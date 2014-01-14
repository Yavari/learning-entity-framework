using learning_entity_framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learning_entity_framework.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}