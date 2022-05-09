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
    class CourseTimeInfoCourseService : Service<CourseTimeInfoCourse>, ICourseTimeInfoCourseService
    {

        public CourseTimeInfoCourseService(IUnitOfWork unitOfWork, IRepository<CourseTimeInfoCourse> repository) : base(unitOfWork, repository)
        {

        }
    }
}
