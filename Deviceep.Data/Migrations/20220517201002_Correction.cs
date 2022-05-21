using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bb13e4e-256e-45d1-9885-4b4e84bf27a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3401aad3-5e9b-4ab7-9ba4-a468e611cfe5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8b9b3f-69d5-4347-8844-51b68c67ffb6");

            migrationBuilder.RenameColumn(
                name: "RFIDUSERS",
                table: "Users",
                newName: "HasRfid");

            

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 16, 30, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7782d260-e691-42af-967f-de7916066691");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eea90535-edfb-4138-870a-e04cd3abbbe6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6185cb6-75d0-4996-8be2-2fdfdfc724d9");

            migrationBuilder.RenameColumn(
                name: "HasRfid",
                table: "Users",
                newName: "RFIDUSERS");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e8b9b3f-69d5-4347-8844-51b68c67ffb6", "ded44f49-4e01-4d13-a885-ae45671898e1", "UserSlave", "USERSLAVE" },
                    { "3401aad3-5e9b-4ab7-9ba4-a468e611cfe5", "6bc4fac7-5b08-449c-9648-d8d5e91e1f72", "UserMaster", "USERMASTER" },
                    { "0bb13e4e-256e-45d1-9885-4b4e84bf27a0", "5bb773b1-a2aa-4122-9a38-ee05c0637e80", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 5, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
