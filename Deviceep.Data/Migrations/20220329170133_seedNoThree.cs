using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class seedNoThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fcb41ed6-a071-4e07-9aa4-6870e83acf45", "09842eea-7e36-48b5-bffa-1de33d05db7d", "UserSlave", "USERSLAVE" },
                    { "f7c1bc37-4c9e-4939-a965-d8e671e44c61", "83a0bc1c-3a1f-478d-8c0b-848792b03505", "UserMaster", "USERMASTER" },
                    { "bb973afa-2b8e-48d0-baef-f9672f61576f", "c259b20d-6a0f-459d-b369-09ca7e3b393b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseDescription", "CourseName", "UserId" },
                values: new object[,]
                {
                    { 1, "Makine Öğrenmesi", "CE304", "5d1b9c35-c8a8-4aa8-b511-bb508beca0bc" },
                    { 2, "Gerçek Zamanlı Sistemler", "CE216", "c6221f92-0234-4720-8c63-eec3a13cb75c" },
                    { 3, "Veri Madenciliği", "CE406", "9cde8b19-d336-4064-95c7-d27efe0398c4" },
                    { 4, "Bilgi Güvenliği", "SF314", "fb16bc16-119c-4abe-8369-8d8c0f37c2ab" },
                    { 5, "Yapay Zeka", "SF213", "06329571-32da-4f66-a3e4-e2a00dc60a0a" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "046002cf-d709-4380-a241-b1426458eb36", "f8db2f14-0bd0-422d-ad54-cf8c6c45bd48", "UserSlave", "USERSLAVE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10e4269a-2e4a-4207-9724-13afc5dc0da6", "9304eb2b-f1dc-430c-ad16-925ed715486b", "UserMaster", "USERMASTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4af4aadc-6bdd-4c56-bbfc-b16a364d0b07", "7ad71af9-9e1d-4dcf-b3b4-3b4d5ca407ec", "Administrator", "ADMINISTRATOR" });
        }
    }
}
