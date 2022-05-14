using Deviceep.Core.Repositories;
using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Repositories
{
    public class AttendanceRepository : Repository<Attendance>, IAttendanceRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public AttendanceRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Attendance> GetWithAttendanceByIdAsync(int Id)
        {
            return await _appDbContext.Attendances.Include(x => x.User).SingleOrDefaultAsync(x => x.Id == Id);
        }
        public async Task<Attendance> GetWithAttendancetsByIdAsync(int Id)
        {
            return await _appDbContext.Attendances.Include(x => x.Course).SingleOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<bool> IsAttendanceExists(string StudentID, int CourseId)
        {
            return await _appDbContext.Attendances.AnyAsync(x => x.UserId == StudentID && x.CourseId == CourseId);
        }
    }
}
