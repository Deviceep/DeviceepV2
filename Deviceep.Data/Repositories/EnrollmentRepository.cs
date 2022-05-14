using Deviceep.Core.Repositories;
using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Repositories
{
    class EnrollmentRepository : Repository<Enrollment>, IEnrollmentRepository

    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public EnrollmentRepository(AppDbContext context) : base(context)
        {
        }

        //public async Task<bool> CheckIfStudentHasClass(string StudId, int CourseId)
        //{
        //   return await _appDbContext.Enrollment.AnyAsync(x => x.UserId == StudId && x.CourseId == CourseId);
        //}

        
    }
}
