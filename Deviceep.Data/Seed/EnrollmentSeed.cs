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
    class EnrollmentSeed : IEntityTypeConfiguration<Enrollments>
    {
        private readonly int[] _ids;

        public EnrollmentSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Enrollments> builder)
        {
            throw new NotImplementedException();
        }
    }
}
