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
    public class AttendanceHourSeed : IEntityTypeConfiguration<AttendanceHour>
    {
        private readonly int[] _ids;

        public AttendanceHourSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<AttendanceHour> builder)
        {
            //builder.HasData(new AttendanceHour
            //{
            //    Id = _ids[0],
            //    Hour = "2",
            //    AttendanceId = _ids[0]

            //},
            //new AttendanceHour
            //{
            //    Id = _ids[1],
            //    Hour = "3",
            //    AttendanceId = _ids[0]
            //}
            //);
        }
    }
}
