using Deviceep.Data.Configurations;
using Deviceep.Data.Seed;
using Deviceep.Entity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deviceep.Data
{
    // IdentityDbContext Used for user interactions
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
       

        // Entities
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceHour> AttendanceHours { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseClassroom> CourseClassrooms { get; set; }
        public DbSet<Enrollments> Enrollments{ get; set; }
        public DbSet<CourseTimeInfo> CourseTimeInfos { get; set; }
        public DbSet<CourseTimeInfoCourse> CourseTimeInfoCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public override DbSet<User> Users { get; set; }
        public  DbSet<UserDepartment> UserDepartments { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // For initializing the Model
            base.OnModelCreating(modelBuilder);


            
            // Configuration instructions being send to the database
            modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
            modelBuilder.ApplyConfiguration(new AttendanceHourConfiguration());
            modelBuilder.ApplyConfiguration(new ClassroomConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseTimeInfoConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new CourseClassroomConfiguration());
            modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseTimeInfoCourseConfiguration());
            modelBuilder.ApplyConfiguration(new UserDepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            // Seeds for sending predetermined data to data base
            //modelBuilder.ApplyConfiguration(new AttendanceSeed(new int[] { 1, 2 }));
            //modelBuilder.ApplyConfiguration(new AttendanceHourSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new ClassroomSeed(new int[] { 1, 2, 3,4,5,6,7,8,9,10 }));
            modelBuilder.ApplyConfiguration(new CourseSeed(new int[] { 1, 2, 3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,
                34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60 }));
            modelBuilder.ApplyConfiguration(new CourseTimeInfoSeed(new int[] { 1, 2, 3, 4, 5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,
            31,32,33,34,35,36,37,38,39,40}));
            modelBuilder.ApplyConfiguration(new DepartmentSeed(new int[] { 1, 2, 3, 4, 5,6, 7,8,9,10,11,12,13,14,15,16,17,18,19,20}));
            modelBuilder.ApplyConfiguration(new FacultySeed(new int[] { 1,2,3,4,5,6 }));
            modelBuilder.ApplyConfiguration(new RoleSeeding());

            //modelBuilder.ApplyConfiguration(new CourseClassRoomSeed(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
            //    25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
            //    61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80}));
            //modelBuilder.ApplyConfiguration(new CourseTimeInfoCourseSeed(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
            //    25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
            //    61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107,
            //    108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140}));
            //modelBuilder.ApplyConfiguration(new UserDepartmentSeed());




        }

    }
}
