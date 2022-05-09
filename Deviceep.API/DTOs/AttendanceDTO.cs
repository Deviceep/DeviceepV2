
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class AttendanceDTO :CreateAttendanceDTO
    {
        public int Id { get; set; }
       

        public virtual UserDTO User { get; set; }
        public virtual CourseTimeInfoDTO Course { get; set; }

        public ICollection<AttendanceHourDTO> AttendanceHours { get; set; }
    }

    public class CreateAttendanceDTO 
    {
        public int UserNo { get; set; }
        public int CourseId { get; set; }
        public string AttendanceDate { get; set; }
    }

    public class UpdateAttendanceDTO : CreateAttendanceDTO
    {

    }
}
