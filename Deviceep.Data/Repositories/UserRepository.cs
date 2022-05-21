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
    class UserRepository : Repository<User>, IUserRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetWithAttendancetsByIdAsync(string rfid)
        {
            return await _appDbContext.Users.SingleOrDefaultAsync(x => x.HasRfid == rfid);
        }
    }
}
