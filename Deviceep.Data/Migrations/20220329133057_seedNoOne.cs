using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deviceep.Data.Migrations
{
    public partial class seedNoOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseTimeInfos",
                columns: new[] { "Id", "CourseDay", "CourseEnd", "CourseStart" },
                values: new object[,]
                {
                    { 1, "Pazartesi", new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Çarşamba", new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Perşembe", new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Perşembe", new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Perşembe", new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Perşembe", new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Perşembe", new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Perşembe", new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Perşembe", new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Perşembe", new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Cuma", new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Cuma", new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Cuma", new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Cuma", new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Cuma", new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Cuma", new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Cuma", new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Cuma", new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Çarşamba", new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Çarşamba", new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Çarşamba", new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Çarşamba", new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pazartesi", new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Pazartesi", new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Pazartesi", new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Pazartesi", new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Pazartesi", new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Pazartesi", new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Çarşamba", new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Salı", new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Salı", new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Pazartesi", new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Salı", new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Salı", new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Salı", new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Salı", new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Salı", new DateTime(2022, 3, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Çarşamba", new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Çarşamba", new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Salı", new DateTime(2022, 3, 29, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 11, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "FacultyName" },
                values: new object[,]
                {
                    { 5, "Ugulamalı Bilimler Fakültesi" },
                    { 1, "Mühendislik ve Doga Bilimleri Fakültesi" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "FacultyName" },
                values: new object[,]
                {
                    { 2, "Fen Edebiyat Fakültesi" },
                    { 3, "İktisadi ve İdari Bilimler Fakültesi" },
                    { 4, "Sanat ve Tasarım Fakültesi" },
                    { 6, "Tıp Fakültesi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CourseTimeInfos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
