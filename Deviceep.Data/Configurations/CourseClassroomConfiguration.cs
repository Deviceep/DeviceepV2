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
    public class CourseClassroomConfiguration : IEntityTypeConfiguration<CourseClassroom>
    {
        public void Configure(EntityTypeBuilder<CourseClassroom> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("CourseClassrooms");
        }
    }
}
