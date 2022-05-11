using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Core.Services
{
    public interface IUserService : IService<User>
    {
        bool IsFieldValueUnique(string ID);
    }
}
