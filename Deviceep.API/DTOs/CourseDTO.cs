using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class CourseDTO : CreateCourseDTO
    {
        public int Id { get; set; }

        public virtual CourseTimeInfoDTO CourseTimeInfo { get; set; }

        public virtual ClassroomDTO Classroom { get; set; }
        public ICollection<AttendanceDTO> Attendances { get; set; }
    }
    public class CreateCourseDTO
    {
        public int TimeInfoId { get; set; }
        public int LecturerId { get; set; }
        public int ClassroomId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        
    }
    public class UpdateCourseDTO : CreateCourseDTO
    {
        
    }
}
