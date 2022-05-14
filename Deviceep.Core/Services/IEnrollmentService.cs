using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Core.Services
{
    public interface IEnrollmentService :  IService<Enrollment>
    {
        Task<bool> IsFieldValueUnique(string ID, int id);
    }
}
