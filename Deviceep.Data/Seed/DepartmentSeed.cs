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
    class DepartmentSeed : IEntityTypeConfiguration<Department>
    {
        private readonly int[] _ids;
        public DepartmentSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(new Department
            {
                Id = _ids[0],
                FacultyId = _ids[0],
                DepartmentName = "Bilgisayar Mühendisliği"
            },
         new Department
         {
             Id = _ids[1],
             FacultyId = _ids[0],
             DepartmentName = "Yazılım Mühendisliği"
         },
         new Department
         {
             Id = _ids[2],
             FacultyId = _ids[0],
             DepartmentName = "Gıda Mühendisliği"
         },
         new Department
         {
             Id = _ids[3],
             FacultyId = _ids[0],
             DepartmentName = "Elektrik Eloktronik Mühendisliği"
         },
         new Department
         {
             Id = _ids[4],
             FacultyId = _ids[0],
             DepartmentName = "Endüstri Mühendisliği"
         },
         new Department
         {
             Id = _ids[5],
             FacultyId = _ids[0],
             DepartmentName = "Mimarlık"
         },
         new Department
         {
             Id = _ids[6],
             FacultyId = _ids[0],
             DepartmentName = "İç Mimarlık ve Çevre Tasarımı"
         },
         new Department
         {
             Id = _ids[7],
             FacultyId = _ids[1],
             DepartmentName = "Fizik"
         },
         new Department
         {
             Id = _ids[8],
             FacultyId = _ids[1],
             DepartmentName = "Matematik"
         },
         new Department
         {
             Id = _ids[9],
             FacultyId = _ids[1],
             DepartmentName = "Moleküler Biyoloji ve Genetik Bölümü"
         },
         new Department
         {
             Id = _ids[10],
             FacultyId = _ids[2],
             DepartmentName = "İktisat"
         },
         new Department
         {
             Id = _ids[11],
             FacultyId = _ids[2],
             DepartmentName = "İşletme"
         },
         new Department
         {
             Id = _ids[12],
             FacultyId = _ids[3],
             DepartmentName = "Müzik ve Sahne Sanatları"
         },
         new Department
         {
             Id = _ids[13],
             FacultyId = _ids[3],
             DepartmentName = "İletişim Tasarımı"
         },
         new Department
         {
             Id = _ids[14],
             FacultyId = _ids[4],
             DepartmentName = "Havacılık Elektroniği Bölümü"
         },
         new Department
         {
             Id = _ids[15],
             FacultyId = _ids[5],
             DepartmentName = "Tıp"
         },
         new Department
         {
             Id = _ids[16],
             FacultyId = _ids[5],
             DepartmentName = "Eczacılık"
         }, new Department
         {
             Id = _ids[17],
             FacultyId = _ids[5],
             DepartmentName = "Dişcilik"
         },
         new Department
         {
             Id = _ids[18],
             FacultyId = _ids[5],
             DepartmentName = "Hemşirelik"
         },
         new Department
         {
             Id = _ids[19],
             FacultyId = _ids[0],
             DepartmentName = "Kontrol Otomasyon Mühendisliği"
         }
         );
        }
    }
}
