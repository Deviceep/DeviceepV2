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
    class ClassroomSeed : IEntityTypeConfiguration<Classroom>
    {
        private readonly int[] _ids;

        public ClassroomSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasData(new Classroom
            {
                Id = _ids[0],
                Major = 1,
                Minor = 1,
                ClassName = "EG002"
            },
          new Classroom
          {
              Id = _ids[1],
              Major = 1,
              Minor = 2,
              ClassName = "EG010"
          },
          new Classroom
          {
              Id = _ids[2],
              Major = 1,
              Minor = 3,
              ClassName = "EG102"
          },

          new Classroom
          {
              Id = _ids[3],
              Major = 2,
              Minor = 1,
              ClassName = "TD105"
          },
          new Classroom
          {
              Id = _ids[4],
              Major = 2,
              Minor = 2,
              ClassName = "TD006"
          },
          new Classroom
          {
              Id = _ids[5],
              Major = 2,
              Minor = 3,
              ClassName = "TD204"
          },
          new Classroom
          {
              Id = _ids[6],
              Major = 3,
              Minor = 1,
              ClassName = "EK102"
          },
          new Classroom
          {
              Id = _ids[7],
              Major = 3,
              Minor = 2,
              ClassName = "EK202"
          },
          new Classroom
          {
              Id = _ids[8],
              Major = 3,
              Minor = 3,
              ClassName = "EK103"
          },
          new Classroom
          {
              Id = _ids[9],
              Major = 3,
              Minor = 4,
              ClassName = "EK005"
          }
          );
        }
    }
}
