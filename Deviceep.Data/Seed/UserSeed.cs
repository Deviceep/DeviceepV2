using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Seed
{
    class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly int[] _ids;

        public UserSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<User> builder)
        {
           // builder.HasData(new User
           // {
           //     UserNo = _ids[1],
           //     Name = "Ahmet",
           //     Surname = "BAGCİVAN",
           //     FacultyId = _ids[1],
           //     DepartmentId = _ids[2]
           // },
           //new User
           //{
           //    UserNo = _ids[1],
           //    Name = "Mehmet",
           //    Surname = "SENER",
           //    FacultyId = _ids[1],
           //    DepartmentId = _ids[2]
           //},
           //new User
           //{
           //    UserNo = _ids[1],
           //    Name = "Umutcan",
           //    Surname = "CAKAR",
           //    FacultyId = _ids[2],
           //    DepartmentId = _ids[3]
           //}
           //);
        }
    }
}
