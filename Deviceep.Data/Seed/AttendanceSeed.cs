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
    public class AttendanceSeed : IEntityTypeConfiguration<Attendance>
    {
        private readonly int[] _ids;

        public AttendanceSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            //builder.HasData(new Attendance
            //{
            //    Id = _ids[0],
            //    UserId = "030718102",
            //    CourseId = _ids[0],
            //    AttendanceDate = "22092022"

            //},
            //new Attendance
            //{
            //    Id = _ids[1],
            //    UserId = "030718102",
            //    CourseId = _ids[1],
            //    AttendanceDate = "22012022"
            //}
            //);
        }
    }
}
