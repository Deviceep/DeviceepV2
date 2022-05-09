using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class SeedNoSix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Minor",
                table: "Classrooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Major",
                table: "Classrooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fa5bd621-00a2-4217-92f5-25d61f6ce55e", "a4349b63-55ca-4a04-8dd5-2d333f1c89ba", "Administrator", "ADMINISTRATOR" },
                    { "c60cfbe4-787f-4bea-a8d5-de690bbc872d", "69c10527-2cd5-4afd-820a-14584752054e", "UserMaster", "USERMASTER" },
                    { "e05795bd-3e10-47b9-bff6-df9a65c70bf8", "2a6ebbdb-4a48-4e0b-a427-c20962946b0e", "UserSlave", "USERSLAVE" }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "ClassName", "Major", "Minor" },
                values: new object[,]
                {
                    { 10, "EK005", 3, 4 },
                    { 9, "EK103", 3, 3 },
                    { 8, "EK202", 3, 2 },
                    { 1, "EG002", 1, 1 },
                    { 6, "TD204", 2, 3 },
                    { 5, "TD006", 2, 2 },
                    { 4, "TD105", 2, 1 },
                    { 3, "EG102", 1, 3 },
                    { 2, "EG010", 1, 2 },
                    { 7, "EK102", 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c60cfbe4-787f-4bea-a8d5-de690bbc872d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e05795bd-3e10-47b9-bff6-df9a65c70bf8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa5bd621-00a2-4217-92f5-25d61f6ce55e");

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Minor",
                table: "Classrooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Major",
                table: "Classrooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8561fc77-79b7-4da1-a1ae-cac785c60762", "08a3550d-be2e-402c-bf17-d599527039d1", "UserSlave", "USERSLAVE" },
                    { "1cdddbf4-d044-40fc-a69d-c044f91808ba", "7e40993c-7cdb-4673-b985-01ab65c7279a", "UserMaster", "USERMASTER" },
                    { "a7a7d7e4-c5cf-4d51-bd1c-2a09cc71c2fd", "5f90228d-216a-4cf2-aef8-0ac3d5e8940c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
