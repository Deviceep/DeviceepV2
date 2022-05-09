using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class Attendance
    {
        public Attendance()
        {
            AttendanceHours = new Collection<AttendanceHour>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public DateTime AttendanceDate { get; set; }
        public ICollection<AttendanceHour> AttendanceHours { get; set; }

    }
}
