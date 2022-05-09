using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class seedNoTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4af4aadc-6bdd-4c56-bbfc-b16a364d0b07", "7ad71af9-9e1d-4dcf-b3b4-3b4d5ca407ec", "Administrator", "ADMINISTRATOR" },
                    { "046002cf-d709-4380-a241-b1426458eb36", "f8db2f14-0bd0-422d-ad54-cf8c6c45bd48", "UserSlave", "USERSLAVE" },
                    { "10e4269a-2e4a-4207-9724-13afc5dc0da6", "9304eb2b-f1dc-430c-ad16-925ed715486b", "UserMaster", "USERMASTER" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName", "FacultyId" },
                values: new object[,]
                {
                    { 20, "Kontrol Otomasyon Mühendisliği", 1 },
                    { 19, "Hemşirelik", 6 },
                    { 18, "Dişcilik", 6 },
                    { 17, "Eczacılık", 6 },
                    { 16, "Tıp", 6 },
                    { 15, "Havacılık Elektroniği Bölümü", 5 },
                    { 14, "İletişim Tasarımı", 4 },
                    { 13, "Müzik ve Sahne Sanatları", 4 },
                    { 12, "İşletme", 3 },
                    { 10, "Moleküler Biyoloji ve Genetik Bölümü", 2 },
                    { 9, "Matematik", 2 },
                    { 8, "Fizik", 2 },
                    { 7, "İç Mimarlık ve Çevre Tasarımı", 1 },
                    { 6, "Mimarlık", 1 },
                    { 5, "Endüstri Mühendisliği", 1 },
                    { 4, "Elektrik Eloktronik Mühendisliği", 1 },
                    { 3, "Gıda Mühendisliği", 1 },
                    { 2, "Yazılım Mühendisliği", 1 },
                    { 11, "İktisat", 3 },
                    { 1, "Bilgisayar Mühendisliği", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "046002cf-d709-4380-a241-b1426458eb36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e4269a-2e4a-4207-9724-13afc5dc0da6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4af4aadc-6bdd-4c56-bbfc-b16a364d0b07");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
