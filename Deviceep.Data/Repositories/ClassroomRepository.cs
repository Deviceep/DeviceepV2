using Deviceep.Core.Repositories;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Data.Repositories
{
    class ClassroomRepository : Repository<Classroom>, IClassroomRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public ClassroomRepository(AppDbContext context) : base(context)
        {
        }
    }
}
