using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Data.Configurations
{
    public class CourseTimeInfoConfiguration : IEntityTypeConfiguration<CourseTimeInfo>
    {
        public void Configure(EntityTypeBuilder<CourseTimeInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CourseDay).IsRequired();
            builder.Property(x => x.CourseStart).IsRequired();
            builder.Property(x => x.CourseEnd).IsRequired();

            builder.ToTable("CourseTimeInfos"); // tablo ismi
        }
    }
}
