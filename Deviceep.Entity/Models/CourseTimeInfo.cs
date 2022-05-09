using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class CourseTimeInfo
    {
        public CourseTimeInfo()
        {
            courseTimeInfoCourses = new HashSet<CourseTimeInfoCourse>();
        }
        public int Id { get; set; }
        public string CourseDay { get; set; }
        public DateTime CourseStart { get; set; } //date time ile değişecek
        public DateTime CourseEnd { get; set; }

        public ICollection<CourseTimeInfoCourse> courseTimeInfoCourses { get; set; }
    }
}
