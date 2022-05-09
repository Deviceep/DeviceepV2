using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class seedNoFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb973afa-2b8e-48d0-baef-f9672f61576f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7c1bc37-4c9e-4939-a965-d8e671e44c61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcb41ed6-a071-4e07-9aa4-6870e83acf45");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f70b3e02-926b-4630-958a-41b88e2bb1b8", "6679a83c-e749-4495-8a10-41a6a4e326f2", "UserSlave", "USERSLAVE" },
                    { "3027398c-7d08-4da1-943c-f53a0d85e33a", "2317f7bb-bd8c-4473-ace4-d19fc9ade5c9", "UserMaster", "USERMASTER" },
                    { "9d632bce-2738-42f1-8188-fdb9040fa8e5", "2cbd7ae8-0df5-485c-a67d-32ec6d5bbc42", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseDescription", "CourseName", "UserId" },
                values: new object[,]
                {
                    { 6, "Yapay Sinir Ağları", "SF418", "a9876d39-a488-44bb-90bd-d792e4fc3a82" },
                    { 7, "Biyolojik Bilimlerin Temeli", "FDE104", "06329571-32da-4f66-a3e4-e2a00dc60a0a" },
                    { 8, "Mühendisler İçin İktisat", "FDE312", "496a0093-7e9f-4174-bd65-96fa0d7e9434" },
                    { 9, "Gıda Proses Mühendisliği", "FDE222", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 10, "Elektromanyetik Alan Teorisi", "EE201", "9cde8b19-d336-4064-95c7-d27efe0398c4" },
                    { 11, "Dever Analizi", "EE215", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" },
                    { 12, "Kompleks Analizi", "EE402", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" },
                    { 13, "Tedarik Zinciri Yönetimi", "ISE314", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 14, "İstatiksel Kalite Kontrol", "ISE236", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 15, "Sistem Dinamiği ve Modelleme", "ISE402", "06329571-32da-4f66-a3e4-e2a00dc60a0a" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fcb41ed6-a071-4e07-9aa4-6870e83acf45", "09842eea-7e36-48b5-bffa-1de33d05db7d", "UserSlave", "USERSLAVE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7c1bc37-4c9e-4939-a965-d8e671e44c61", "83a0bc1c-3a1f-478d-8c0b-848792b03505", "UserMaster", "USERMASTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb973afa-2b8e-48d0-baef-f9672f61576f", "c259b20d-6a0f-459d-b369-09ca7e3b393b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
