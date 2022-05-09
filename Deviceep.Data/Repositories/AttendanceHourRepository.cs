using Deviceep.Core.Repositories;
using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Repositories
{
    public class AttendanceHourRepository : Repository<AttendanceHour>, IAttendanceHourRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public AttendanceHourRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<AttendanceHour> GetWithAttendanceHourByIdAsync(int Id)
        {
            return await _appDbContext.AttendanceHours.Include(x => x.Attendance).SingleOrDefaultAsync(x => x.Id == Id);
        }

        
    }
}
