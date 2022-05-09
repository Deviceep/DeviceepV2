using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Service.Services
{
    public class FacultyService : Service<Faculty>, IFacultyService
    {
        public FacultyService(IUnitOfWork unitOfWork, IRepository<Faculty> repository) : base(unitOfWork, repository)
        {

        }
    }
}
