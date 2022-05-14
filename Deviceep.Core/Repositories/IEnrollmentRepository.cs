using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Core.Repositories
{
    public interface IEnrollmentRepository : IRepository<Enrollment>
    {

        public Task<bool> CheckIfStudentHasClass(string StudId, int CourseId);
    }
}
