using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Attendances = new HashSet<Attendance>();
            Enrollments = new HashSet<Enrollment>();
            UserDepartments = new HashSet<UserDepartment>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string RFID { get; set; }
        
       
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<UserDepartment> UserDepartments { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
