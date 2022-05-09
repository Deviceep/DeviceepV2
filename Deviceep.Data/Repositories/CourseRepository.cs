using Deviceep.Core.Repositories;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public CourseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
