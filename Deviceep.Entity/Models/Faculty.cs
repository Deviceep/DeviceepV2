using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Deviceep.Entity.Models
{
    public class Faculty
    {
        public Faculty()
        {
            Departments = new HashSet<Department>();
        }
        public int Id { get; set; }
        public string FacultyName { get; set; }
       
        public ICollection<Department> Departments { get; set; }


    }
}
