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
    class FacultySeed : IEntityTypeConfiguration<Faculty>
    {
        private readonly int[] _ids;
        public FacultySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasData(new Faculty
            {
                Id = _ids[0],
                FacultyName = "Mühendislik ve Doga Bilimleri Fakültesi"
            },
        new Faculty
        {
            Id = _ids[1],
            FacultyName = "Fen Edebiyat Fakültesi"
        },
        new Faculty
        {
            Id = _ids[2],
            FacultyName = "İktisadi ve İdari Bilimler Fakültesi"
        },
        new Faculty
        {
            Id = _ids[3],
            FacultyName = "Sanat ve Tasarım Fakültesi"
        },
        new Faculty
        {
            Id = _ids[4],
            FacultyName = "Ugulamalı Bilimler Fakültesi"
        },
        new Faculty
        {
            Id = _ids[5],
            FacultyName = "Tıp Fakültesi"
        }
        );
        }
    }
}
