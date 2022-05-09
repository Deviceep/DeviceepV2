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
    class CourseClassRoomSeed : IEntityTypeConfiguration<CourseClassroom>
    {
        private readonly int[] _ids;

        public CourseClassRoomSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<CourseClassroom> builder)
        {
            builder.HasData(new CourseClassroom
            {
                Id = _ids[0],


                CourseId = 1,
                ClassroomId = 1 
            },new CourseClassroom
            {
                Id = _ids[1],


                CourseId = 12,
                ClassroomId = 1
            },
            new CourseClassroom
            {
                Id = _ids[2],


                CourseId = 1,
                ClassroomId = 2
            }, new CourseClassroom
            {
                Id = _ids[3],


                CourseId = 2,
                ClassroomId = 2
            }, new CourseClassroom
            {
                Id = _ids[4],


                CourseId = 2,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[5],


                CourseId = 3,
                ClassroomId = 1
            }, new CourseClassroom
            {
                Id = _ids[6],


                CourseId = 5,
                ClassroomId = 7
            }, new CourseClassroom
            {
                Id = _ids[7],


                CourseId = 4,
                ClassroomId = 7
            }, new CourseClassroom
            {
                Id = _ids[8],


                CourseId = 6,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[9],


                CourseId = 6,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[10],


                CourseId = 7,
                ClassroomId = 1
            },
            new CourseClassroom
            {
                Id = _ids[11],


                CourseId = 8,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[12],


                CourseId = 8,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[13],


                CourseId = 9,
                ClassroomId = 10
            }, new CourseClassroom
            {
                Id = _ids[14],


                CourseId = 10,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[15],


                CourseId = 11,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[16],


                CourseId = 11,
                ClassroomId = 5
            }, new CourseClassroom
            {
                Id = _ids[17],


                CourseId = 13,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[18],


                CourseId = 14,
                ClassroomId = 2
            }, new CourseClassroom
            {
                Id = _ids[19],


                CourseId = 15,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[20],


                CourseId = 15,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[21],


                CourseId = 16,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[22],


                CourseId = 17,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[23],


                CourseId = 18,
                ClassroomId = 7
            }, new CourseClassroom
            {
                Id = _ids[24],


                CourseId = 19,
                ClassroomId = 10
            }, new CourseClassroom
            {
                Id = _ids[25],


                CourseId = 20,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[26],


                CourseId = 21,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[27],


                CourseId = 22,
                ClassroomId = 8
            }, new CourseClassroom
            {
                Id = _ids[28],


                CourseId = 23,
                ClassroomId = 5
            }, new CourseClassroom
            {
                Id = _ids[29],


                CourseId = 23,
                ClassroomId = 7
            }, new CourseClassroom
            {
                Id = _ids[30],


                CourseId = 23,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[31],


                CourseId = 24,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[32],


                CourseId = 24,
                ClassroomId = 2
            }, new CourseClassroom
            {
                Id = _ids[33],


                CourseId = 25,
                ClassroomId = 1
            }, new CourseClassroom
            {
                Id = _ids[34],


                CourseId = 26,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[35],


                CourseId = 27,
                ClassroomId = 8
            }, new CourseClassroom
            {
                Id = _ids[36],


                CourseId = 27,
                ClassroomId = 8
            }, new CourseClassroom
            {
                Id = _ids[37],


                CourseId = 28,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[38],


                CourseId = 29,
                ClassroomId = 10
            }, new CourseClassroom
            {
                Id = _ids[39],


                CourseId = 30,
                ClassroomId = 10
            }, new CourseClassroom
            {
                Id = _ids[40],


                CourseId = 30,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[41],


                CourseId = 31,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[42],


                CourseId = 32,
                ClassroomId = 8
            }, new CourseClassroom
            {
                Id = _ids[43],


                CourseId = 33,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[44],


                CourseId = 34,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[45],


                CourseId = 35,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[46],


                CourseId = 36,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[47],


                CourseId = 37,
                ClassroomId = 7
            }, new CourseClassroom
            {
                Id = _ids[48],


                CourseId = 38,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[49],


                CourseId = 39,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[50],


                CourseId = 39,
                ClassroomId = 2
            }, new CourseClassroom
            {
                Id = _ids[51],


                CourseId = 40,
                ClassroomId = 5
            }, new CourseClassroom
            {
                Id = _ids[52],


                CourseId = 41,
                ClassroomId = 5
            }, new CourseClassroom
            {
                Id = _ids[53],


                CourseId = 42,
                ClassroomId = 8
            }, new CourseClassroom
            {
                Id = _ids[54],


                CourseId = 41,
                ClassroomId = 7
            }, new CourseClassroom
            {
                Id = _ids[55],


                CourseId = 42,
                ClassroomId = 5
            }, new CourseClassroom
            {
                Id = _ids[56],


                CourseId = 43,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[57],


                CourseId = 44,
                ClassroomId = 1
            }, new CourseClassroom
            {
                Id = _ids[58],


                CourseId = 45,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[59],


                CourseId = 46,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[60],


                CourseId = 47,
                ClassroomId = 7
            }, new CourseClassroom
            {
                Id = _ids[61],


                CourseId = 48,
                ClassroomId = 2
            }, new CourseClassroom
            {
                Id = _ids[62],


                CourseId = 48,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[63],


                CourseId = 49,
                ClassroomId = 10
            }, new CourseClassroom
            {
                Id = _ids[64],


                CourseId = 50,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[65],


                CourseId = 51,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[66],


                CourseId = 52,
                ClassroomId = 3
            }, new CourseClassroom
            {
                Id = _ids[67],


                CourseId = 53,
                ClassroomId = 1
            },new CourseClassroom
            {
                Id = _ids[68],


                CourseId = 53,
                ClassroomId = 5
            }, new CourseClassroom
            {
                Id = _ids[69],


                CourseId = 54,
                ClassroomId = 1
            }, new CourseClassroom
            {
                Id = _ids[70],


                CourseId = 55,
                ClassroomId = 10
            }, new CourseClassroom
            {
                Id = _ids[71],


                CourseId = 56,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[72],


                CourseId = 56,
                ClassroomId = 1
            }, new CourseClassroom
            {
                Id = _ids[73],


                CourseId = 57,
                ClassroomId = 5
            }, new CourseClassroom
            {
                Id = _ids[74],


                CourseId = 58,
                ClassroomId = 9
            }, new CourseClassroom
            {
                Id = _ids[75],


                CourseId = 58,
                ClassroomId = 1
            }, new CourseClassroom
            {
                Id = _ids[76],


                CourseId = 59,
                ClassroomId = 6
            }, new CourseClassroom
            {
                Id = _ids[77],


                CourseId = 60,
                ClassroomId = 4
            }, new CourseClassroom
            {
                Id = _ids[78],


                CourseId = 36,
                ClassroomId = 1
            }
            );
        }
    }
}
