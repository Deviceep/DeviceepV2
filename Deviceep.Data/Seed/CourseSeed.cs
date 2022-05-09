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
    class CourseSeed : IEntityTypeConfiguration<Course>
    {
        private readonly int[] _ids;

        public CourseSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            
            builder.HasData(new Course
            {
                Id = _ids[0],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "CE304",
                CourseDescription = "Makine Öğrenmesi"
            },
            new Course
            {
                Id = _ids[1],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "CE216",
                CourseDescription = "Gerçek Zamanlı Sistemler"
            }, new Course
            {
                Id = _ids[2],

                UserId = "9cde8b19-d336-4064-95c7-d27efe0398c4",

                CourseName = "CE406",
                CourseDescription = "Veri Madenciliği"
            }, new Course
            {
                Id = _ids[3],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "SF314",
                CourseDescription = "Bilgi Güvenliği"
            }, new Course
            {
                Id = _ids[4],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "SF213",
                CourseDescription = "Yapay Zeka"

                //**
            }, new Course
            {
                Id = _ids[5],

                UserId = "a9876d39-a488-44bb-90bd-d792e4fc3a82",

                CourseName = "SF418",
                CourseDescription = "Yapay Sinir Ağları"
                // 06329571-32da-4f66-a3e4-e2a00dc60a0a Amanı Hocamız <3
                // 06329571-32da-4f66-a3e4-e2a00dc60a0a
                //496a0093-7e9f-4174-bd65-96fa0d7e9434 Akhtar Hoca
                //496a0093-7e9f-4174-bd65-96fa0d7e9434
                //5d1b9c35-c8a8-4aa8-b511-bb508beca0bc Muhamed Hoca
                //5d1b9c35-c8a8-4aa8-b511-bb508beca0bc
                //9cde8b19-d336-4064-95c7-d27efe0398c4 Kasım Hoca
                //9cde8b19-d336-4064-95c7-d27efe0398c4
                //a9876d39-a488-44bb-90bd-d792e4fc3a82 Kevser Nur Hoca
                //a9876d39-a488-44bb-90bd-d792e4fc3a82
                //c6221f92-0234-4720-8c63-eec3a13cb75c Ayşenur Hoca
                //c6221f92-0234-4720-8c63-eec3a13cb75c
                //fb16bc16-119c-4abe-8369-8d8c0f37c2ab Hakan Hoca
                //fb16bc16-119c-4abe-8369-8d8c0f37c2ab
            }, new Course
            {
                Id = _ids[6],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "FDE104",
                CourseDescription = "Biyolojik Bilimlerin Temeli"
            }, new Course
            {
                Id = _ids[7],

                UserId = "496a0093-7e9f-4174-bd65-96fa0d7e9434",

                CourseName = "FDE312",
                CourseDescription = "Mühendisler İçin İktisat"
            }, new Course
            {
                Id = _ids[8],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "FDE222",
                CourseDescription = "Gıda Proses Mühendisliği"
            }, new Course
            {
                Id = _ids[9],

                UserId = "9cde8b19-d336-4064-95c7-d27efe0398c4",

                CourseName = "EE201",
                CourseDescription = "Elektromanyetik Alan Teorisi"
            }, new Course
            {
                Id = _ids[10],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "EE215",
                CourseDescription = "Dever Analizi"
            }, new Course
            {
                Id = _ids[11],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "EE402",
                CourseDescription = "Kompleks Analizi"
            }, new Course

            {
                Id = _ids[12],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "ISE314",
                CourseDescription = "Tedarik Zinciri Yönetimi"
            }, new Course
            {
                Id = _ids[13],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "ISE236",
                CourseDescription = "İstatiksel Kalite Kontrol"
            }, new Course
            {
                Id = _ids[14],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "ISE402",
                CourseDescription = "Sistem Dinamiği ve Modelleme"
            }, new Course

                {
                Id = _ids[15],

                    UserId = "a9876d39-a488-44bb-90bd-d792e4fc3a82",

                    CourseName = "ARCH202",
                    CourseDescription = "Tasarım Çalışmaları"
                }, new Course
            {
                Id = _ids[16],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "ARCH312",
                CourseDescription = "Mimari Tasarım"
            }, new Course
            {
                Id = _ids[17],

                UserId = "496a0093-7e9f-4174-bd65-96fa0d7e9434",

                CourseName = "ARCH402",
                CourseDescription = "Bina Bilgisi"
            }, new Course
            {
                Id = _ids[18],

                UserId = "9cde8b19-d336-4064-95c7-d27efe0398c4",

                CourseName = "ICT112",
                CourseDescription = "Tasarım Temelleri"
            }, new Course
            {
                Id = _ids[19],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "ICT213",
                CourseDescription = "Malzeme ve Teknoloji"
            }, new Course
            {
                Id = _ids[20],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "ICT313",
                CourseDescription = "İç Mimari Tasarım Stüdyosu"
            }, new Course

            {
                Id = _ids[21],

                UserId = "9cde8b19-d336-4064-95c7-d27efe0398c4",

                CourseName = "PHS214",
                CourseDescription = "Evreni Tanımak"
            }, new Course
            {
                Id = _ids[22],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "PHS315",
                CourseDescription = "Bilgi Ve Entropi"
            }, new Course
            {
                Id = _ids[23],

                UserId = "a9876d39-a488-44bb-90bd-d792e4fc3a82",

                CourseName = "PHS402",
                CourseDescription = "Fizikçiler Elektroniği"
            }, new Course
            {
                Id = _ids[24],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "MAT211",
                CourseDescription = "Diferansiyel Denklemler"
            }, new Course
            {
                Id = _ids[25],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "MAT202",
                CourseDescription = "Ayrık Matematik"
            }, new Course
            {
                Id = _ids[26],

                UserId = "9cde8b19-d336-4064-95c7-d27efe0398c4",

                CourseName = "MAT402",
                CourseDescription = "Analitik Geometri"
            }, new Course
            {

                Id = _ids[27],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "BIOL101",
                CourseDescription = "Moleküler Biyoloji Ve Genetiğe Giriş"
            }, new Course
            {
                Id = _ids[28],

                UserId = "a9876d39-a488-44bb-90bd-d792e4fc3a82",

                CourseName = "BIOL316",
                CourseDescription = "Moleküler Hücre Biyolojisi"
            }, new Course
            {
                Id = _ids[29],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "BIOL405",
                CourseDescription = "Davranış Genetiği"
            }, new Course
            {
                Id = _ids[30],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "ECON201",
                CourseDescription = "Kariyer Planlama"
            }, new Course
            {
                Id = _ids[31],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "ECON302",
                CourseDescription = "Ekonometri"
            }, new Course
            {
                Id = _ids[32],

                UserId = "9cde8b19-d336-4064-95c7-d27efe0398c4",

                CourseName = "ECON231",
                CourseDescription = "Para Teorisi"
            }, new Course
            {

                Id = _ids[33],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "BSU212",
                CourseDescription = "Para Politikası"
            }, new Course
            {
                Id = _ids[34],

                UserId = "496a0093-7e9f-4174-bd65-96fa0d7e9434",

                CourseName = "BSU305",
                CourseDescription = "Uluslararası Finans"
            }, new Course
            {
                Id = _ids[35],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "BSU406",
                CourseDescription = "Kamu Maliyesi"
            }, new Course
            {
                Id = _ids[36],

                UserId = "a9876d39-a488-44bb-90bd-d792e4fc3a82",

                CourseName = "MZK106",
                CourseDescription = "Temel Piyano"
            }, new Course
            {
                Id = _ids[37],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "MZK304",
                CourseDescription = "Bireysel Çalgı"
            }, new Course
            {
                Id = _ids[38],

                UserId = "a9876d39-a488-44bb-90bd-d792e4fc3a82",

                CourseName = "MZK203",
                CourseDescription = "Bireysel Ses Eğitimi"
            }, new Course
            {

                Id = _ids[39],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "ILT103",
                CourseDescription = "İletişime Giriş"
            }, new Course
            {
                Id = _ids[40],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "ILT205",
                CourseDescription = "Yazılı Anlatım"
            }, new Course
            {
                Id = _ids[41],

                UserId = "496a0093-7e9f-4174-bd65-96fa0d7e9434",

                CourseName = "ILT303",
                CourseDescription = "Genel İletişim Araştırmaları"
            }, new Course
            {
                Id = _ids[42],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "FHS103",
                CourseDescription = "Hemşirelikte Eğitim"
            }, new Course
            {
                Id = _ids[43],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "HYO201",
                CourseDescription = "Havacılık Kuralları"
            }, new Course
            {
                Id = _ids[44],

                UserId = "a9876d39-a488-44bb-90bd-d792e4fc3a82",

                CourseName = "HYO212",
                CourseDescription = "Uçak Malzeme Bilgisi"
            }, new Course
            {
                Id = _ids[45],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "HYO316",
                CourseDescription = "Uçak Yapıları Ve Sistemleri"
            }, new Course
            {

                Id = _ids[46],

                UserId = "9cde8b19-d336-4064-95c7-d27efe0398c4",

                CourseName = "MED103",
                CourseDescription = "Klinik Uygulamalara Giriş"
            }, new Course
            {
                Id = _ids[47],

                UserId = "496a0093-7e9f-4174-bd65-96fa0d7e9434",

                CourseName = "MED305",
                CourseDescription = "Adli Tıp"
            }, new Course
            {
                Id = _ids[48],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "MED408",
                CourseDescription = "Nöroloji"
            }, new Course
            {
                Id = _ids[49],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "PHAR108",
                CourseDescription = "Sağlık Bilimleri İçin Fizik"
            }, new Course
            {
                Id = _ids[50],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "PHAR305",
                CourseDescription = "Eczacılık Bilgisayar Kullanımı"
            }, new Course
            {
                Id = _ids[51],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "PHAR101",
                CourseDescription = "Eczacılığa Giriş"
            }, new Course
            {
                Id = _ids[52],

                UserId = "c6221f92-0234-4720-8c63-eec3a13cb75c",

                CourseName = "DENT301",
                CourseDescription = "Protetik Diş Tedavisi"
            }, new Course
            {
                Id = _ids[53],

                UserId = "496a0093-7e9f-4174-bd65-96fa0d7e9434",

                CourseName = "DENT306",
                CourseDescription = "Endodonti"
            }, new Course
            {
                Id = _ids[54],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "DENT407",
                CourseDescription = "Kariyoloji ve Koruyucu Diş Hekimliği"
            }, new Course
            {
                /* 
          06329571-32da-4f66-a3e4-e2a00dc60a0a Amanı Hocamız <3
          06329571-32da-4f66-a3e4-e2a00dc60a0a
         496a0093-7e9f-4174-bd65-96fa0d7e9434 Akhtar Hoca
         496a0093-7e9f-4174-bd65-96fa0d7e9434
         5d1b9c35-c8a8-4aa8-b511-bb508beca0bc Muhamed Hoca
         5d1b9c35-c8a8-4aa8-b511-bb508beca0bc
         9cde8b19-d336-4064-95c7-d27efe0398c4 Kasım Hoca
         9cde8b19-d336-4064-95c7-d27efe0398c4
         a9876d39-a488-44bb-90bd-d792e4fc3a82 Kevser Nur Hoca
         a9876d39-a488-44bb-90bd-d792e4fc3a82
         c6221f92-0234-4720-8c63-eec3a13cb75c Ayşenur Hoca
         c6221f92-0234-4720-8c63-eec3a13cb75c
         fb16bc16-119c-4abe-8369-8d8c0f37c2ab Hakan Hoca
         fb16bc16-119c-4abe-8369-8d8c0f37c2ab
          */
                Id = _ids[55],

                UserId = "496a0093-7e9f-4174-bd65-96fa0d7e9434",

                CourseName = "FHS307",
                CourseDescription = "Farmakolojinin İlkeleri"
            }, new Course
            {
                Id = _ids[56],

                UserId = "fb16bc16-119c-4abe-8369-8d8c0f37c2ab",

                CourseName = "FHS404",
                CourseDescription = "Cerrahi Hastalıkları Hemşireliği"
            }, new Course
            {
                Id = _ids[57],

                UserId = "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc",

                CourseName = "KON102",
                CourseDescription = "Elektroniğe Giriş"
            }, new Course
            {
                Id = _ids[58],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "KON206",
                CourseDescription = "İşaretler ve Sistemler"
            }, new Course
            {
                Id = _ids[59],

                UserId = "06329571-32da-4f66-a3e4-e2a00dc60a0a",

                CourseName = "KON403",
                CourseDescription = "Ölçme Tekniği ve Algılayıcılar"
            }

             );
            
        }
    }
}
