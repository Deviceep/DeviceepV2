using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Core.Repositories
{
    public interface IAttendanceRepository : IRepository<Attendance>
        
    {
        public Task<Attendance> GetWithAttendanceByIdAsync(int Id);
        public Task<Attendance> GetWithAttendancetsByIdAsync(int Id);
    }
}
