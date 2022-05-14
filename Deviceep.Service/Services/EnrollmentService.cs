using Deviceep.Core.Repositories;
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
    public class EnrollmentService : Service<Enrollments>, IEnrollmentService
    {

        

        public EnrollmentService(IUnitOfWork unitOfWork, IRepository<Enrollments> repository) : base(unitOfWork, repository)
        {
            
        }

        //x => {} böyleli bişey deneyelim
        public async Task<bool> IsFieldValueUnique(string ID, int id)
        {
            return await _unitOfWork.Enrollments.CheckIfStudentHasClass(ID, id);
           
        }
    }
}
