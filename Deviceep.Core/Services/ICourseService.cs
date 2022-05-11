﻿using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Core.Services
{
    public interface ICourseService : IService<Course>
    {
        bool IsFieldValueUnique(int ID);
    }
}
