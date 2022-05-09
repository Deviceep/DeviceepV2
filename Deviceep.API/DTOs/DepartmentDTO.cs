using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class DepartmentDTO : CreateDepartmentDTO
    {
        public int Id { get; set; }
        

        public ICollection<UserDepartmentDTO> userDepartmentDTO { get; set; }
    }
    public class CreateDepartmentDTO
    {
        public string DepartmentName { get; set; }
        public int FacultyId { get; set; }
    }
    public class UpdateDepartmentDTO : CreateDepartmentDTO
    {

    }
}
