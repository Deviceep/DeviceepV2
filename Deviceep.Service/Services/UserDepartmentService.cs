using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Service.Services
{
    class UserDepartmentService : Service<UserDepartment>, IUserDepartmentService
    {



        public UserDepartmentService(IUnitOfWork unitOfWork, IRepository<UserDepartment> repository) : base(unitOfWork, repository)
        {

        }
    }
}
