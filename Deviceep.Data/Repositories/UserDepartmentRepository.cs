using Deviceep.Core.Repositories;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Repositories
{
    class UserDepartmentRepository : Repository<UserDepartment>, IUserDepartmentRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public UserDepartmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
