using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class SeedNoSeven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f548dcaf-7564-4777-8c43-a09a2a88e4fd", "d7a0dc8d-f87c-4ebe-b9e2-7d0d14563c1e", "Administrator", "ADMINISTRATOR" },
                    { "42fcc530-5fab-4dfa-bad4-25e9e5fbd343", "159c4fa3-5fb0-4a03-a6f2-259385c1c9d1", "UserMaster", "USERMASTER" },
                    { "daf463c4-e00a-4420-874e-f8e36c4a9c45", "d4bf57d3-4a9e-4d6f-b7b0-287f2ed6a3d0", "UserSlave", "USERSLAVE" }
                });

            migrationBuilder.InsertData(
                table: "CourseClassrooms",
                columns: new[] { "Id", "ClassroomId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 58, 1, 44 },
                    { 57, 9, 43 },
                    { 56, 5, 42 },
                    { 55, 7, 41 },
                    { 54, 8, 42 },
                    { 53, 5, 41 },
                    { 52, 5, 40 },
                    { 50, 3, 39 },
                    { 59, 6, 45 },
                    { 49, 9, 38 },
                    { 48, 7, 37 },
                    { 47, 3, 36 },
                    { 46, 4, 35 },
                    { 45, 6, 34 },
                    { 44, 4, 33 },
                    { 51, 2, 39 },
                    { 60, 3, 46 },
                    { 63, 9, 48 },
                    { 43, 8, 32 },
                    { 79, 1, 36 },
                    { 78, 4, 60 },
                    { 77, 6, 59 },
                    { 76, 1, 58 },
                    { 75, 9, 58 },
                    { 74, 5, 57 },
                    { 73, 1, 56 },
                    { 62, 2, 48 },
                    { 72, 9, 56 },
                    { 70, 1, 54 },
                    { 69, 5, 53 },
                    { 68, 1, 53 },
                    { 67, 3, 52 },
                    { 66, 6, 51 },
                    { 65, 6, 50 },
                    { 64, 10, 49 },
                    { 71, 10, 55 },
                    { 42, 4, 31 },
                    { 61, 7, 47 }
                });

            migrationBuilder.InsertData(
                table: "CourseClassrooms",
                columns: new[] { "Id", "ClassroomId", "CourseId" },
                values: new object[,]
                {
                    { 40, 10, 30 },
                    { 18, 3, 13 },
                    { 17, 5, 11 },
                    { 16, 4, 11 },
                    { 15, 9, 10 },
                    { 14, 10, 9 },
                    { 13, 4, 8 },
                    { 12, 3, 8 },
                    { 11, 1, 7 },
                    { 10, 4, 6 },
                    { 9, 9, 6 },
                    { 8, 7, 4 },
                    { 7, 7, 5 },
                    { 6, 1, 3 },
                    { 5, 4, 2 },
                    { 4, 2, 2 },
                    { 3, 2, 1 },
                    { 41, 3, 30 },
                    { 19, 2, 14 },
                    { 20, 6, 15 },
                    { 2, 1, 12 },
                    { 22, 3, 16 },
                    { 39, 10, 29 },
                    { 38, 4, 28 },
                    { 37, 8, 27 },
                    { 36, 8, 27 },
                    { 34, 1, 25 },
                    { 33, 2, 24 },
                    { 32, 6, 24 },
                    { 31, 4, 23 },
                    { 35, 9, 26 },
                    { 29, 5, 23 },
                    { 28, 8, 22 },
                    { 27, 4, 21 },
                    { 26, 6, 20 },
                    { 30, 7, 23 },
                    { 25, 10, 19 },
                    { 24, 7, 18 },
                    { 23, 4, 17 },
                    { 21, 3, 15 }
                });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseEnd", "CourseStart" },
                values: new object[] { new DateTime(2022, 4, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fcc530-5fab-4dfa-bad4-25e9e5fbd343");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf463c4-e00a-4420-874e-f8e36c4a9c45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f548dcaf-7564-4777-8c43-a09a2a88e4fd");

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CourseClassrooms",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e05795bd-3e10-47b9-bff6-df9a65c70bf8", "2a6ebbdb-4a48-4e0b-a427-c20962946b0e", "UserSlave", "USERSLAVE" },
                    { "c60cfbe4-787f-4bea-a8d5-de690bbc872d", "69c10527-2cd5-4afd-820a-14584752054e", "UserMaster", "USERMASTER" },
                    { "fa5bd621-00a2-4217-92f5-25d61f6ce55e", "a4349b63-55ca-4a04-8dd5-2d333f1c89ba", "Administrator", "ADMINISTRATOR" }
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
    }
}
