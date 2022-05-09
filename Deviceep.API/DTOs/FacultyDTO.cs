using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class FacultyDTO : CreateFacultyDTO
    {
        public int Id { get; set; }
        

        public ICollection<DepartmentDTO> Departments { get; set; }
    }
    public class CreateFacultyDTO
    {
        public string FacultyName { get; set; }
    }
    public class UpdateFacultyDTO : CreateFacultyDTO
    {

    }
    
}

