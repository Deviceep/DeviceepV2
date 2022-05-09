using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class AttendanceHour
    {
        public int Id { get; set; }
        public int AttendanceId { get; set; }
        public virtual Attendance Attendance { get; set; }
        public DateTime Hour { get; set; }

        
    }
}
