using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Service.Services
{
    public class ClassroomService : Service<Classroom>, IClassroomService
    {
        public ClassroomService(IUnitOfWork unitOfWork, IRepository<Classroom> repository) : base(unitOfWork, repository)
        {

        }
    }
}

