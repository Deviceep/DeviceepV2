using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
    public class CreateUserDTO : UserDTO
    {
    }
    public class UpdateUserDTO : UserDTO
    {
        
    }
    public class UserDTO : LoginUserDTO
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
       

        public ICollection<string> Roles { get; set; }
        public ICollection<string> Departments { get; set; }

        //public virtual FacultyDTO Faculty { get; set; }
        //public virtual DepartmentDTO Department { get; set; } // department olanı departmentDTO yaptık


        // public ICollection<AttendanceDTO> Attendances { get; set; }


    }
}
