
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class AttendanceHourDTO : CreateAttendanceHourDTO
    {
        public int Id { get; set; }
      

        public virtual AttendanceDTO Attendance { get; set; }
    }

    public class CreateAttendanceHourDTO
    {
        public int AttendanceId { get; set; }
        public DateTime Hour { get; set; }
    }
    public class UpdateAttendanceHourDTO : CreateAttendanceHourDTO
    {

    }
}
