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
    class CourseTimeInfoCourseSeed : IEntityTypeConfiguration<CourseTimeInfoCourse>
    {
        private readonly int[] _ids;

        public CourseTimeInfoCourseSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<CourseTimeInfoCourse> builder)
        {
            builder.HasData(new CourseTimeInfoCourse
            {
                Id  = _ids[0],
                CourseId = 1,
                CouseTimeInfoId = 1
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[1],
                CourseId = 1,
                CouseTimeInfoId = 2
            }, new CourseTimeInfoCourse
            {
                Id = _ids[2],
                CourseId = 1,
                CouseTimeInfoId = 17
            }, new CourseTimeInfoCourse
            {
                Id = _ids[3],
                CourseId = 2,
                CouseTimeInfoId = 8
            }, new CourseTimeInfoCourse
            {
                Id = _ids[4],
                CourseId = 2,
                CouseTimeInfoId = 39
            }, new CourseTimeInfoCourse
            {
                Id = _ids[5],
                CourseId = 2,
                CouseTimeInfoId = 40
            }, new CourseTimeInfoCourse
            {
                Id = _ids[6],
                CourseId = 3,
                CouseTimeInfoId = 17
            }, new CourseTimeInfoCourse
            {
                Id = _ids[7],
                CourseId = 3,
                CouseTimeInfoId = 18
            }, new CourseTimeInfoCourse
            {
                Id = _ids[8],
                CourseId = 3,
                CouseTimeInfoId = 32
            }, new CourseTimeInfoCourse
            {
                Id = _ids[9],
                CourseId = 4,
                CouseTimeInfoId = 33
            }, new CourseTimeInfoCourse
            {
                Id = _ids[10],
                CourseId = 4,
                CouseTimeInfoId = 34
            }, new CourseTimeInfoCourse
            {
                Id = _ids[11],
                CourseId = 5,
                CouseTimeInfoId = 1
            }, new CourseTimeInfoCourse
            {
                Id = _ids[12],
                CourseId = 5,
                CouseTimeInfoId = 2
            }, new CourseTimeInfoCourse
            {
                Id = _ids[13],
                CourseId = 5,
                CouseTimeInfoId = 3
            }, new CourseTimeInfoCourse
            {
                Id = _ids[14],
                CourseId = 6,
                CouseTimeInfoId = 8
            }, new CourseTimeInfoCourse
            {
                Id = _ids[15],
                CourseId = 6,
                CouseTimeInfoId = 17
            }, new CourseTimeInfoCourse
            {
                Id = _ids[16],
                CourseId = 6,
                CouseTimeInfoId = 18
            }, new CourseTimeInfoCourse
            {
                Id = _ids[17],
                CourseId = 7,
                CouseTimeInfoId = 13
            }, new CourseTimeInfoCourse
            {
                Id = _ids[18],
                CourseId = 7,
                CouseTimeInfoId = 14
            }, new CourseTimeInfoCourse
            {
                Id = _ids[19],
                CourseId = 7,
                CouseTimeInfoId = 25
            }, new CourseTimeInfoCourse
            {
                Id = _ids[20],
                CourseId = 8,
                CouseTimeInfoId = 33
            }, new CourseTimeInfoCourse
            {
                Id = _ids[21],
                CourseId = 9,
                CouseTimeInfoId = 5
            }, new CourseTimeInfoCourse
            {
                Id = _ids[22],
                CourseId = 9,
                CouseTimeInfoId = 6
            }, new CourseTimeInfoCourse
            {
                Id = _ids[23],
                CourseId = 10,
                CouseTimeInfoId = 27
            }, new CourseTimeInfoCourse
            {
                Id = _ids[24],
                CourseId = 10,
                CouseTimeInfoId = 28
            }, new CourseTimeInfoCourse
            {
                Id = _ids[25],
                CourseId = 11,
                CouseTimeInfoId = 35
            }, new CourseTimeInfoCourse
            {
                Id = _ids[26],
                CourseId = 11,
                CouseTimeInfoId = 36
            }, new CourseTimeInfoCourse
            {
                Id = _ids[27],
                CourseId = 12,
                CouseTimeInfoId = 15
            }, new CourseTimeInfoCourse
            {
                Id = _ids[28],
                CourseId = 12,
                CouseTimeInfoId = 16
            }, new CourseTimeInfoCourse
            {
                Id = _ids[29],
                CourseId = 12,
                CouseTimeInfoId = 37
            },new CourseTimeInfoCourse
            {
                Id = _ids[30],
                CourseId = 10,
                CouseTimeInfoId = 38
            }, new CourseTimeInfoCourse
            {
                Id = _ids[31],
                CourseId = 13,
                CouseTimeInfoId = 12
            }, new CourseTimeInfoCourse
            {
                Id = _ids[32],
                CourseId = 13,
                CouseTimeInfoId = 13
            }, new CourseTimeInfoCourse
            {
                Id = _ids[33],
                CourseId = 13,
                CouseTimeInfoId = 35
            }, new CourseTimeInfoCourse
            {
                Id = _ids[34],
                CourseId = 14,
                CouseTimeInfoId = 23
            }, new CourseTimeInfoCourse
            {
                Id = _ids[35],
                CourseId = 14,
                CouseTimeInfoId = 24
            }, new CourseTimeInfoCourse
            {
                Id = _ids[36],
                CourseId = 15,
                CouseTimeInfoId = 6
            }, new CourseTimeInfoCourse
            {
                Id = _ids[37],
                CourseId = 15,
                CouseTimeInfoId = 7
            }, new CourseTimeInfoCourse
            {
                Id = _ids[38],
                CourseId = 15,
                CouseTimeInfoId = 8
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[39],
                CourseId = 16,
                CouseTimeInfoId = 1
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[40],
                CourseId = 16,
                CouseTimeInfoId = 2
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[41],
                CourseId = 17,
                CouseTimeInfoId = 15
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[42],
                CourseId = 17,
                CouseTimeInfoId = 16
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[43],
                CourseId = 17,
                CouseTimeInfoId = 17
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[44],
                CourseId = 18,
                CouseTimeInfoId = 27
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[45],
                CourseId = 18,
                CouseTimeInfoId = 28
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[46],
                CourseId = 19,
                CouseTimeInfoId = 33
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[47],
                CourseId = 19,
                CouseTimeInfoId = 34
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[48],
                CourseId = 20,
                CouseTimeInfoId = 19
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[49],
                CourseId = 20,
                CouseTimeInfoId = 20
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[50],
                CourseId = 21,
                CouseTimeInfoId = 7
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[51],
                CourseId = 21,
                CouseTimeInfoId = 8
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[52],
                CourseId = 22,
                CouseTimeInfoId = 1
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[53],
                CourseId = 22,
                CouseTimeInfoId = 2
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[54],
                CourseId = 23,
                CouseTimeInfoId = 27
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[55],
                CourseId = 23,
                CouseTimeInfoId = 28
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[56],
                CourseId = 23,
                CouseTimeInfoId = 29
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[57],
                CourseId = 24,
                CouseTimeInfoId = 31
            },

            new CourseTimeInfoCourse
            {
                Id = _ids[58],
                CourseId = 24,
                CouseTimeInfoId = 32
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[59],
                CourseId = 25,
                CouseTimeInfoId = 9
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[60],
                CourseId = 25,
                CouseTimeInfoId = 10
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[61],
                CourseId = 25,
                CouseTimeInfoId = 26
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[62],
                CourseId = 25,
                CouseTimeInfoId = 27
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[63],
                CourseId = 26,
                CouseTimeInfoId = 35
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[64],
                CourseId = 26,
                CouseTimeInfoId = 36
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[65],
                CourseId = 27,
                CouseTimeInfoId = 10
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[66],
                CourseId = 27,
                CouseTimeInfoId = 11
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[67],
                CourseId = 28,
                CouseTimeInfoId = 15
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[68],
                CourseId = 28,
                CouseTimeInfoId = 16
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[69],
                CourseId = 29,
                CouseTimeInfoId = 18
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[70],
                CourseId = 29,
                CouseTimeInfoId = 19
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[71],
                CourseId = 30,
                CouseTimeInfoId = 23
            },
            new CourseTimeInfoCourse
            {
                Id = _ids[72],
                CourseId = 30,
                CouseTimeInfoId = 24
            },
            /* MUSA alt taraf Bitti */
            new CourseTimeInfoCourse
            {
                Id = _ids[73],
                CourseId = 31,
                CouseTimeInfoId = 7
            }, new CourseTimeInfoCourse
            {
                Id = _ids[74],
                CourseId = 31,
                CouseTimeInfoId = 14
            }, new CourseTimeInfoCourse
            {
                Id = _ids[75],
                CourseId = 32,
                CouseTimeInfoId = 17
            }, new CourseTimeInfoCourse
            {
                Id = _ids[76],
                CourseId = 32,
                CouseTimeInfoId = 18
            }, new CourseTimeInfoCourse
            {
                Id = _ids[77],
                CourseId = 32,
                CouseTimeInfoId = 26
            }, new CourseTimeInfoCourse
            {
                Id = _ids[78],
                CourseId = 33,
                CouseTimeInfoId = 27
            }, new CourseTimeInfoCourse
            {
                Id = _ids[79],
                CourseId = 33,
                CouseTimeInfoId = 28
            }, new CourseTimeInfoCourse
            {
                Id = _ids[80],
                CourseId = 33,
                CouseTimeInfoId = 29
            }, new CourseTimeInfoCourse
            {
                Id = _ids[81],
                CourseId = 34,
                CouseTimeInfoId = 32
            }, new CourseTimeInfoCourse
            {
                Id = _ids[82],
                CourseId = 34,
                CouseTimeInfoId = 33
            }, new CourseTimeInfoCourse
            {
                Id = _ids[83],
                CourseId = 35,
                CouseTimeInfoId = 30
            }, new CourseTimeInfoCourse
            {
                Id = _ids[84],
                CourseId = 35,
                CouseTimeInfoId = 31
            }, new CourseTimeInfoCourse
            {
                Id = _ids[85],
                CourseId = 36,
                CouseTimeInfoId = 7
            }, new CourseTimeInfoCourse
            {
                Id = _ids[86],
                CourseId = 36,
                CouseTimeInfoId = 8
            }, new CourseTimeInfoCourse
            {
                Id = _ids[87],
                CourseId = 37,
                CouseTimeInfoId = 1
            }, new CourseTimeInfoCourse
            {
                Id = _ids[88],
                CourseId = 37,
                CouseTimeInfoId = 2
            }, new CourseTimeInfoCourse
            {
                Id = _ids[89],
                CourseId = 38,
                CouseTimeInfoId = 25
            }, new CourseTimeInfoCourse
            {
                Id = _ids[90],
                CourseId = 38,
                CouseTimeInfoId = 26
            }, new CourseTimeInfoCourse
            {
                Id = _ids[91],
                CourseId = 39,
                CouseTimeInfoId = 9
            }, new CourseTimeInfoCourse
            {
                Id = _ids[92],
                CourseId = 39,
                CouseTimeInfoId = 10
            }, new CourseTimeInfoCourse
            {
                Id = _ids[93],
                CourseId = 40,
                CouseTimeInfoId = 16
            }, new CourseTimeInfoCourse
            {
                Id = _ids[94],
                CourseId = 40,
                CouseTimeInfoId = 17
            }, new CourseTimeInfoCourse
            {
                Id = _ids[95],
                CourseId = 41,
                CouseTimeInfoId = 13
            }, new CourseTimeInfoCourse
            {
                Id = _ids[96],
                CourseId = 41,
                CouseTimeInfoId = 14
            }, new CourseTimeInfoCourse
            {
                Id = _ids[97],
                CourseId = 42,
                CouseTimeInfoId = 17
            }, new CourseTimeInfoCourse
            {
                Id = _ids[98],
                CourseId = 42,
                CouseTimeInfoId = 24
            }, new CourseTimeInfoCourse
            {
                Id = _ids[99],
                CourseId = 43,
                CouseTimeInfoId = 4
            }, new CourseTimeInfoCourse
            {
                Id = _ids[100],
                CourseId = 43,
                CouseTimeInfoId = 5
            }, new CourseTimeInfoCourse
            {
                Id = _ids[101],
                CourseId = 43,
                CouseTimeInfoId = 6
            }, new CourseTimeInfoCourse
            {
                Id = _ids[102],
                CourseId = 44,
                CouseTimeInfoId = 33
            }, new CourseTimeInfoCourse
            {
                Id = _ids[103],
                CourseId = 44,
                CouseTimeInfoId = 34
            }, new CourseTimeInfoCourse
            {
                Id = _ids[104],
                CourseId = 45,
                CouseTimeInfoId = 30
            }, new CourseTimeInfoCourse
            {
                Id = _ids[105],
                CourseId = 45,
                CouseTimeInfoId = 31
            }, new CourseTimeInfoCourse
            {
                Id = _ids[106],
                CourseId = 46,
                CouseTimeInfoId = 33
            }, new CourseTimeInfoCourse
            {
                Id = _ids[107],
                CourseId = 46,
                CouseTimeInfoId = 34
            }, new CourseTimeInfoCourse
            {
                Id = _ids[108],
                CourseId = 46,
                CouseTimeInfoId = 35
            }, new CourseTimeInfoCourse
            {
                Id = _ids[109],
                CourseId = 47,
                CouseTimeInfoId = 9
            }, new CourseTimeInfoCourse
            {
                Id = _ids[110],
                CourseId = 47,
                CouseTimeInfoId = 10
            }, new CourseTimeInfoCourse
            {
                Id = _ids[111],
                CourseId = 47,
                CouseTimeInfoId = 11
            }, new CourseTimeInfoCourse
            {
                Id = _ids[112],
                CourseId = 48,
                CouseTimeInfoId = 20
            }, new CourseTimeInfoCourse
            {
                Id = _ids[113],
                CourseId = 48,
                CouseTimeInfoId = 21
            }, new CourseTimeInfoCourse
            {
                Id = _ids[114],
                CourseId = 48,
                CouseTimeInfoId = 22
            }, new CourseTimeInfoCourse
            {
                Id = _ids[115],
                CourseId = 49,
                CouseTimeInfoId = 5
            }, new CourseTimeInfoCourse
            {
                Id = _ids[116],
                CourseId = 49,
                CouseTimeInfoId = 6
            }, new CourseTimeInfoCourse
            {
                Id = _ids[117],
                CourseId = 50,
                CouseTimeInfoId = 14
            }, new CourseTimeInfoCourse
            {
                Id = _ids[118],
                CourseId = 50,
                CouseTimeInfoId = 15
            }, new CourseTimeInfoCourse
            {
                Id = _ids[119],
                CourseId = 51,
                CouseTimeInfoId = 26
            }, new CourseTimeInfoCourse
            {
                Id = _ids[120],
                CourseId = 51,
                CouseTimeInfoId = 27
            }, new CourseTimeInfoCourse
            {
                Id = _ids[121],
                CourseId = 52,
                CouseTimeInfoId = 6
            }, new CourseTimeInfoCourse
            {
                Id = _ids[122],
                CourseId = 52,
                CouseTimeInfoId = 7
            }, new CourseTimeInfoCourse
            {
                Id = _ids[123],
                CourseId = 52,
                CouseTimeInfoId = 8
            }, new CourseTimeInfoCourse
            {
                Id = _ids[124],
                CourseId = 53,
                CouseTimeInfoId = 21
            }, new CourseTimeInfoCourse
            {
                Id = _ids[125],
                CourseId = 53,
                CouseTimeInfoId = 22
            }, new CourseTimeInfoCourse
            {
                Id = _ids[125],
                CourseId = 53,
                CouseTimeInfoId = 23
            }, new CourseTimeInfoCourse
            {
                Id = _ids[126],
                CourseId = 54,
                CouseTimeInfoId = 35
            }, new CourseTimeInfoCourse
            {
                Id = _ids[127],
                CourseId = 54,
                CouseTimeInfoId = 36
            }, new CourseTimeInfoCourse
            {
                Id = _ids[128],
                CourseId = 55,
                CouseTimeInfoId = 18
            }, new CourseTimeInfoCourse
            {
                Id = _ids[129],
                CourseId = 55,
                CouseTimeInfoId = 19
            }, new CourseTimeInfoCourse
            {
                Id = _ids[130],
                CourseId = 56,
                CouseTimeInfoId = 25
            }, new CourseTimeInfoCourse
            {
                Id = _ids[131],
                CourseId = 56,
                CouseTimeInfoId = 26
            }, new CourseTimeInfoCourse
            {
                Id = _ids[132],
                CourseId = 57,
                CouseTimeInfoId = 35
            }, new CourseTimeInfoCourse
            {
                Id = _ids[133],
                CourseId = 57,
                CouseTimeInfoId = 36
            }, new CourseTimeInfoCourse
            {
                Id = _ids[134],
                CourseId = 58,
                CouseTimeInfoId = 39
            }, new CourseTimeInfoCourse
            {
                Id = _ids[135],
                CourseId = 58,
                CouseTimeInfoId = 40
            }, new CourseTimeInfoCourse
            {
                Id = _ids[136],
                CourseId = 59,
                CouseTimeInfoId = 21
            }, new CourseTimeInfoCourse
            {
                Id = _ids[137],
                CourseId = 59,
                CouseTimeInfoId = 22
            }, new CourseTimeInfoCourse
            {
                Id = _ids[138],
                CourseId = 60,
                CouseTimeInfoId = 9
            }, new CourseTimeInfoCourse
            {
                Id = _ids[139],
                CourseId = 60,
                CouseTimeInfoId = 10
            }
            );
            }
        }
}
