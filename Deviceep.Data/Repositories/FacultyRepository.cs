using Deviceep.Core.Repositories;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Repositories
{
    class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public FacultyRepository(AppDbContext context) : base(context)
        {
        }
    }
}
