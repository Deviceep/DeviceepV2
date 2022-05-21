using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Core.Services
{
    public interface IUserService : IService<User>
    {
        bool IsFieldValueUnique(string ID);
        public Task<User> GetWithAttendancetsByIdAsync(string rfid);
    }
}
