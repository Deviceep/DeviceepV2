using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class ClassroomDTO : CreateClassroomDTO
    {
        
        public int Id { get; set; }
     
        public ICollection<CourseTimeInfoDTO> Courses { get; set; }
    }
    public class CreateClassroomDTO
    {

        public string Major { get; set; }
        public string Minor { get; set; }
        public string ClassName { get; set; }

    }

    public class UpdateClassroomDTO : CreateClassroomDTO
    {

    }
}
