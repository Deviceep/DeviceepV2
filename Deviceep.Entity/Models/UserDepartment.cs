using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Entity.Models
{
    public class UserDepartment
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }


    }
}
