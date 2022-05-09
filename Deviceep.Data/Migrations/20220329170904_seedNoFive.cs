using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class seedNoFive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3027398c-7d08-4da1-943c-f53a0d85e33a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d632bce-2738-42f1-8188-fdb9040fa8e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f70b3e02-926b-4630-958a-41b88e2bb1b8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7a7d7e4-c5cf-4d51-bd1c-2a09cc71c2fd", "5f90228d-216a-4cf2-aef8-0ac3d5e8940c", "Administrator", "ADMINISTRATOR" },
                    { "1cdddbf4-d044-40fc-a69d-c044f91808ba", "7e40993c-7cdb-4673-b985-01ab65c7279a", "UserMaster", "USERMASTER" },
                    { "8561fc77-79b7-4da1-a1ae-cac785c60762", "08a3550d-be2e-402c-bf17-d599527039d1", "UserSlave", "USERSLAVE" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: "9cde8b19-d336-4064-95c7-d27efe0398c4");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseDescription", "CourseName", "UserId" },
                values: new object[,]
                {
                    { 59, "İşaretler ve Sistemler", "KON206", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 42, "Genel İletişim Araştırmaları", "ILT303", "496a0093-7e9f-4174-bd65-96fa0d7e9434" },
                    { 43, "Hemşirelikte Eğitim", "FHS103", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 44, "Havacılık Kuralları", "HYO201", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 45, "Uçak Malzeme Bilgisi", "HYO212", "a9876d39-a488-44bb-90bd-d792e4fc3a82" },
                    { 46, "Uçak Yapıları Ve Sistemleri", "HYO316", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 47, "Klinik Uygulamalara Giriş", "MED103", "9cde8b19-d336-4064-95c7-d27efe0398c4" },
                    { 48, "Adli Tıp", "MED305", "496a0093-7e9f-4174-bd65-96fa0d7e9434" },
                    { 49, "Nöroloji", "MED408", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 50, "Sağlık Bilimleri İçin Fizik", "PHAR108", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 51, "Eczacılık Bilgisayar Kullanımı", "PHAR305", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 41, "Yazılı Anlatım", "ILT205", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 53, "Protetik Diş Tedavisi", "DENT301", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 54, "Endodonti", "DENT306", "496a0093-7e9f-4174-bd65-96fa0d7e9434" },
                    { 55, "Kariyoloji ve Koruyucu Diş Hekimliği", "DENT407", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 56, "Farmakolojinin İlkeleri", "FHS307", "496a0093-7e9f-4174-bd65-96fa0d7e9434" },
                    { 57, "Cerrahi Hastalıkları Hemşireliği", "FHS404", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 58, "Elektroniğe Giriş", "KON102", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" },
                    { 60, "Ölçme Tekniği ve Algılayıcılar", "KON403", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 52, "Eczacılığa Giriş", "PHAR101", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" },
                    { 40, "İletişime Giriş", "ILT103", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" },
                    { 38, "Bireysel Çalgı", "MZK304", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 17, "Mimari Tasarım", "ARCH312", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 18, "Bina Bilgisi", "ARCH402", "496a0093-7e9f-4174-bd65-96fa0d7e9434" },
                    { 19, "Tasarım Temelleri", "ICT112", "9cde8b19-d336-4064-95c7-d27efe0398c4" },
                    { 20, "Malzeme ve Teknoloji", "ICT213", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 21, "İç Mimari Tasarım Stüdyosu", "ICT313", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" },
                    { 22, "Evreni Tanımak", "PHS214", "9cde8b19-d336-4064-95c7-d27efe0398c4" },
                    { 23, "Bilgi Ve Entropi", "PHS315", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 24, "Fizikçiler Elektroniği", "PHS402", "a9876d39-a488-44bb-90bd-d792e4fc3a82" },
                    { 25, "Diferansiyel Denklemler", "MAT211", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 26, "Ayrık Matematik", "MAT202", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 27, "Analitik Geometri", "MAT402", "9cde8b19-d336-4064-95c7-d27efe0398c4" },
                    { 28, "Moleküler Biyoloji Ve Genetiğe Giriş", "BIOL101", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 29, "Moleküler Hücre Biyolojisi", "BIOL316", "a9876d39-a488-44bb-90bd-d792e4fc3a82" },
                    { 30, "Davranış Genetiği", "BIOL405", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 31, "Kariyer Planlama", "ECON201", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 32, "Ekonometri", "ECON302", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseDescription", "CourseName", "UserId" },
                values: new object[,]
                {
                    { 33, "Para Teorisi", "ECON231", "9cde8b19-d336-4064-95c7-d27efe0398c4" },
                    { 34, "Para Politikası", "BSU212", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 35, "Uluslararası Finans", "BSU305", "496a0093-7e9f-4174-bd65-96fa0d7e9434" },
                    { 36, "Kamu Maliyesi", "BSU406", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 37, "Temel Piyano", "MZK106", "a9876d39-a488-44bb-90bd-d792e4fc3a82" },
                    { 39, "Bireysel Ses Eğitimi", "MZK203", "a9876d39-a488-44bb-90bd-d792e4fc3a82" },
                    { 16, "Tasarım Çalışmaları", "ARCH202", "a9876d39-a488-44bb-90bd-d792e4fc3a82" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cdddbf4-d044-40fc-a69d-c044f91808ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8561fc77-79b7-4da1-a1ae-cac785c60762");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7a7d7e4-c5cf-4d51-bd1c-2a09cc71c2fd");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f70b3e02-926b-4630-958a-41b88e2bb1b8", "6679a83c-e749-4495-8a10-41a6a4e326f2", "UserSlave", "USERSLAVE" },
                    { "3027398c-7d08-4da1-943c-f53a0d85e33a", "2317f7bb-bd8c-4473-ace4-d19fc9ade5c9", "UserMaster", "USERMASTER" },
                    { "9d632bce-2738-42f1-8188-fdb9040fa8e5", "2cbd7ae8-0df5-485c-a67d-32ec6d5bbc42", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: " 9cde8b19-d336-4064-95c7-d27efe0398c4");
        }
    }
}
