using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class CreateCourseTimeInfoDTO
    {
        public string CourseDay { get; set; }
        public string CourseStart { get; set; }
        public string CourseEnd { get; set; }
    }
    public class CourseTimeInfoDTO : CreateCourseTimeInfoDTO
    {
        public int Id { get; set; }
        public ICollection<CourseTimeInfoDTO> Courses { get; set; }
    }
    public class UpdateCourseTimeInfoDTO : CreateCourseTimeInfoDTO
    {

    }
    
}
