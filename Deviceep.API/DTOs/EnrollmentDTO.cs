using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.DTOs
{
    public class EnrollmentDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
       
      
        public int CourseId { get; set; }
       
        public DateTime EnrollmentYear { get; set; }
        public string EnrollmentTerm { get; set; }
    }
}
