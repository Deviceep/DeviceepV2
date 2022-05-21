using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {

        public Task<User> GetWithAttendancetsByIdAsync(string rfid);
    }
}
