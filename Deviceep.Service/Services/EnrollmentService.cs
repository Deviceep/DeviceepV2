﻿using Deviceep.Core.Repositories;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Core.Services;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Service.Services
{
    class EnrollmentService : Service<Enrollment>, IEnrollmentService
    {



        public EnrollmentService(IUnitOfWork unitOfWork, IRepository<Enrollment> repository) : base(unitOfWork, repository)
        {

        }
    }
}
