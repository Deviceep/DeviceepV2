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
    public class AttendanceService : Service<Attendance>, IAttendanceService
    {
        


        public AttendanceService(IUnitOfWork unitOfWork, IRepository<Attendance> repository) : base(unitOfWork, repository)
        {

        }
    }
}
