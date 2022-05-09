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
    public class AttendanceHourService : Service<AttendanceHour>, IAttendanceHourService
    {

        public AttendanceHourService(IUnitOfWork unitOfWork, IRepository<AttendanceHour> repository) : base(unitOfWork, repository)
        {

        }
    }
}
