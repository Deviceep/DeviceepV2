using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Entity.Models
{
    public class CourseClassroom
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ClassroomId { get; set; }

        public Course Course { get; set; }
        public Classroom Classroom { get; set; }
    }
}
