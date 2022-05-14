using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Core.Services
{
    public interface IAttendanceService : IService<Attendance>
    {
        public Task<bool> IsAttendanceExists(string StudentID, int CourseId);
    }
}
