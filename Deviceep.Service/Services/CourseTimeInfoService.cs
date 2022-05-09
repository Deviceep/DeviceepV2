using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Service.Services
{
    public class CourseTimeInfoService : Service<CourseTimeInfo>, ICourseTimeInfoService
    {
        public CourseTimeInfoService(IUnitOfWork unitOfWork, IRepository<CourseTimeInfo> repository) : base(unitOfWork, repository)
        {

        }
    }
}
