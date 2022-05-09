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
    class CourseTimeInfoSeed : IEntityTypeConfiguration<CourseTimeInfo>
    {
        private readonly int[] _ids;
        public CourseTimeInfoSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<CourseTimeInfo> builder)
        {

            builder.HasData(new CourseTimeInfo
            {
                Id = _ids[0],
                CourseDay = "Pazartesi",
                CourseStart = DateTime.ParseExact("09:30:00","HH:mm:ss",null),
                CourseEnd = DateTime.ParseExact("10:30:00", "HH:mm:ss", null)
            },
          new CourseTimeInfo
          {
              Id = _ids[1],
              CourseDay = "Pazartesi",
              CourseStart = DateTime.ParseExact("10:30:00", "HH:mm:ss", null),
              CourseEnd = DateTime.ParseExact("11:30:00", "HH:mm:ss", null)
          },
          new CourseTimeInfo
          {
              Id = _ids[2],
              CourseDay = "Pazartesi",
              CourseStart = DateTime.ParseExact("11:30:00", "HH:mm:ss", null),
              CourseEnd = DateTime.ParseExact("12:30:00", "HH:mm:ss", null)
          },
           new CourseTimeInfo
           {
               Id = _ids[3],
               CourseDay = "Pazartesi",
               CourseStart = DateTime.ParseExact("12:30:00", "HH:mm:ss", null),
               CourseEnd = DateTime.ParseExact("13:30:00", "HH:mm:ss", null)
           },
            new CourseTimeInfo
            {
                Id = _ids[4],
                CourseDay = "Pazartesi",
                CourseStart = DateTime.ParseExact("13:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("14:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[5],
                CourseDay = "Pazartesi",
                CourseStart = DateTime.ParseExact("14:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("15:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[6],
                CourseDay = "Pazartesi",
                CourseStart = DateTime.ParseExact("15:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("16:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[7],
                CourseDay = "Pazartesi",
                CourseStart = DateTime.ParseExact("16:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("17:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[8],
                CourseDay = "Salı",
                CourseStart = DateTime.ParseExact("09:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("10:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[9],
                CourseDay = "Salı",
                CourseStart = DateTime.ParseExact("10:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("11:30:00", "HH:mm:ss", null)
            },
          new CourseTimeInfo
          {
              Id = _ids[10],
              CourseDay = "Salı",
              CourseStart = DateTime.ParseExact("11:30:00", "HH:mm:ss", null),
              CourseEnd = DateTime.ParseExact("12:30:00", "HH:mm:ss", null)
          },
           new CourseTimeInfo
           {
               Id = _ids[11],
               CourseDay = "Salı",
               CourseStart = DateTime.ParseExact("12:30:00", "HH:mm:ss", null),
               CourseEnd = DateTime.ParseExact("13:30:00", "HH:mm:ss", null)
           },
            new CourseTimeInfo
            {
                Id = _ids[12],
                CourseDay = "Salı",
                CourseStart = DateTime.ParseExact("13:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("14:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[13],
                CourseDay = "Salı",
                CourseStart = DateTime.ParseExact("14:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("15:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[14],
                CourseDay = "Salı",
                CourseStart = DateTime.ParseExact("15:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("16:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[15],
                CourseDay = "Salı",
                CourseStart = DateTime.ParseExact("16:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("17:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[16],
                CourseDay = "Çarşamba",
                CourseStart = DateTime.ParseExact("09:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("10:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[17],
                CourseDay = "Çarşamba",
                CourseStart = DateTime.ParseExact("10:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("11:30:00", "HH:mm:ss", null)
            },
          new CourseTimeInfo
          {
              Id = _ids[18],
              CourseDay = "Çarşamba",
              CourseStart = DateTime.ParseExact("11:30:00", "HH:mm:ss", null),
              CourseEnd = DateTime.ParseExact("12:30:00", "HH:mm:ss", null)
          },
           new CourseTimeInfo
           {
               Id = _ids[19],
               CourseDay = "Çarşamba",
               CourseStart = DateTime.ParseExact("12:30:00", "HH:mm:ss", null),
               CourseEnd = DateTime.ParseExact("13:30:00", "HH:mm:ss", null)
           },
            new CourseTimeInfo
            {
                Id = _ids[20],
                CourseDay = "Çarşamba",
                CourseStart = DateTime.ParseExact("13:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("14:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[21],
                CourseDay = "Çarşamba",
                CourseStart = DateTime.ParseExact("14:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("15:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[22],
                CourseDay = "Çarşamba",
                CourseStart = DateTime.ParseExact("15:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("16:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[23],
                CourseDay = "Çarşamba",
                CourseStart = DateTime.ParseExact("16:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("17:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[24],
                CourseDay = "Perşembe",
                CourseStart = DateTime.ParseExact("09:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("10:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[25],
                CourseDay = "Perşembe",
                CourseStart = DateTime.ParseExact("10:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("11:30:00", "HH:mm:ss", null)
            },
          new CourseTimeInfo
          {
              Id = _ids[26],
              CourseDay = "Perşembe",
              CourseStart = DateTime.ParseExact("11:30:00", "HH:mm:ss", null),
              CourseEnd = DateTime.ParseExact("12:30:00", "HH:mm:ss", null)
          },
           new CourseTimeInfo
           {
               Id = _ids[27],
               CourseDay = "Perşembe",
               CourseStart = DateTime.ParseExact("12:30:00", "HH:mm:ss", null),
               CourseEnd = DateTime.ParseExact("13:30:00", "HH:mm:ss", null)
           },
            new CourseTimeInfo
            {
                Id = _ids[28],
                CourseDay = "Perşembe",
                CourseStart = DateTime.ParseExact("13:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("14:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[29],
                CourseDay = "Perşembe",
                CourseStart = DateTime.ParseExact("14:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("15:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[30],
                CourseDay = "Perşembe",
                CourseStart = DateTime.ParseExact("15:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("16:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[31],
                CourseDay = "Perşembe",
                CourseStart = DateTime.ParseExact("16:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("17:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[32],
                CourseDay = "Cuma",
                CourseStart = DateTime.ParseExact("09:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("10:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[33],
                CourseDay = "Cuma",
                CourseStart = DateTime.ParseExact("10:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("11:30:00", "HH:mm:ss", null)
            },
          new CourseTimeInfo
          {
              Id = _ids[34],
              CourseDay = "Cuma",
              CourseStart = DateTime.ParseExact("11:30:00", "HH:mm:ss", null),
              CourseEnd = DateTime.ParseExact("12:30:00", "HH:mm:ss", null)
          },
           new CourseTimeInfo
           {
               Id = _ids[35],
               CourseDay = "Cuma",
               CourseStart = DateTime.ParseExact("12:30:00", "HH:mm:ss", null),
               CourseEnd = DateTime.ParseExact("13:30:00", "HH:mm:ss", null)
           },
            new CourseTimeInfo
            {
                Id = _ids[36],
                CourseDay = "Cuma",
                CourseStart = DateTime.ParseExact("13:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("14:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[37],
                CourseDay = "Cuma",
                CourseStart = DateTime.ParseExact("14:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("15:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[38],
                CourseDay = "Cuma",
                CourseStart = DateTime.ParseExact("15:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("16:30:00", "HH:mm:ss", null)
            },
            new CourseTimeInfo
            {
                Id = _ids[39],
                CourseDay = "Cuma",
                CourseStart = DateTime.ParseExact("16:30:00", "HH:mm:ss", null),
                CourseEnd = DateTime.ParseExact("17:30:00", "HH:mm:ss", null)
            }
          );
        }
    }
}
