using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Service.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<User> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<User> GetWithAttendancetsByIdAsync(string rfid)
        {
            var AlreadyExist = await _unitOfWork.Users.GetWithAttendancetsByIdAsync(rfid);
            return AlreadyExist;
        }

        public bool IsFieldValueUnique(string ID)
        {
            var AlreadyExists = _unitOfWork.Users.IsFieldValueUnique(x => x.Id == ID);
            return AlreadyExists;
        }
    }
}
