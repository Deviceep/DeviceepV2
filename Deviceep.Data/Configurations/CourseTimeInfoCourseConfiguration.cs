using Deviceep.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.Configurations
{
    public class CourseTimeInfoCourseConfiguration : IEntityTypeConfiguration<CourseTimeInfoCourse>
    {
        public void Configure(EntityTypeBuilder<CourseTimeInfoCourse> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("CourseTimeInfoCourses");

        }
    }
}
