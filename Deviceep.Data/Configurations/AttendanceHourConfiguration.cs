using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Data.Configurations
{
    public class AttendanceHourConfiguration : IEntityTypeConfiguration<AttendanceHour>
    {
        public void Configure(EntityTypeBuilder<AttendanceHour> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Hour).IsRequired();
            builder.ToTable("AttendanceHours"); // tablo ismi
        }
    }
}
