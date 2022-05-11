using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Service.Services
{
    public class CourseService : Service<Course>, ICourseService 
    {
        public CourseService(IUnitOfWork unitOfWork, IRepository<Course> repository) : base(unitOfWork, repository)
        {

        }

        public bool IsFieldValueUnique(int ID)
        {
            var AlreadyExists = _unitOfWork.Courses.IsFieldValueUnique(x => x.Id == ID);
            return AlreadyExists;
        }
    }
}
