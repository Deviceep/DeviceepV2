using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class Course
    {
        public Course()
        {
            Attendances = new HashSet<Attendance>();
            CourseTimeInfoCourses = new HashSet<CourseTimeInfoCourse>();
            Enrollments = new HashSet<Enrollment>();
            CourseClassrooms = new HashSet<CourseClassroom>();

        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        

        
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseTimeInfoCourse> CourseTimeInfoCourses { get; set; }
        public ICollection<CourseClassroom> CourseClassrooms { get; set; }

    }
}
