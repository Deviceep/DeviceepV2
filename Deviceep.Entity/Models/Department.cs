using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class Department
    {
        public Department()
        {

            UserDepartments = new HashSet<UserDepartment>();
        }
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int FacultyId { get; set; }

        public Faculty Faculty { get; set; }
        public ICollection<UserDepartment> UserDepartments { get; set; }
    }
}
