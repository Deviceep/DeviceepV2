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
    public class EnrollmentService : Service<Enrollment>, IEnrollmentService
    {

        public readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService(IUnitOfWork unitOfWork, IRepository<Enrollment> repository, IEnrollmentRepository enrollmentRepository) : base(unitOfWork, repository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        // x => {} böyleli bişey deneyelim
        public async Task<bool> IsFieldValueUnique(string ID, int id)
        {
            return await _enrollmentRepository.CheckIfStudentHasClass(ID, id);
        }
    }
}
