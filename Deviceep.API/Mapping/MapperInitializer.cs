using AutoMapper;
using Deviceep.API.DTOs;
using Deviceep.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.Mapping
{
    public class MapperInitializer
    {
        public class MapperInitilizer : Profile
        {

            // Mapping connects the database models with API's DTO's for further use
            public MapperInitilizer()
            {
                // Attendance
                CreateMap<Attendance, AttendanceDTO>().ReverseMap();
                CreateMap<Attendance, CreateAttendanceDTO>().ReverseMap();
                CreateMap<Attendance, UpdateAttendanceDTO>().ReverseMap();
                // Attendance Hour
                CreateMap<AttendanceHour, AttendanceHourDTO>().ReverseMap();
                CreateMap<AttendanceHour, CreateAttendanceHourDTO>().ReverseMap();
                CreateMap<AttendanceHour, UpdateAttendanceHourDTO>().ReverseMap();
                // Classroom
                CreateMap<Classroom, ClassroomDTO>().ReverseMap();
                CreateMap<Classroom, CreateClassroomDTO>().ReverseMap();
                CreateMap<Classroom, UpdateClassroomDTO>().ReverseMap();
                // Course
                CreateMap<Course, CourseTimeInfoDTO>().ReverseMap();
                CreateMap<Course, CreateCourseDTO>().ReverseMap();
                CreateMap<Course, UpdateCourseDTO>().ReverseMap();
                // CourseTimeInfo
                CreateMap<CourseTimeInfo, CourseTimeInfoDTO>().ReverseMap();
                CreateMap<CourseTimeInfo, CreateCourseTimeInfoDTO>().ReverseMap();
                CreateMap<CourseTimeInfo, UpdateCourseTimeInfoDTO>().ReverseMap();
                // Department
                CreateMap<Department, DepartmentDTO>().ReverseMap();
                CreateMap<Department, CreateDepartmentDTO>().ReverseMap();
                CreateMap<Department, UpdateDepartmentDTO>().ReverseMap();
                // Faculty
                CreateMap<Faculty, CreateFacultyDTO>().ReverseMap();
                CreateMap<Faculty, UpdateFacultyDTO>().ReverseMap();
                CreateMap<Faculty, FacultyDTO>().ReverseMap();
                // User
                CreateMap<User, UserDTO>().ReverseMap();
                CreateMap<User, LoginUserDTO>().ReverseMap();
                CreateMap<User, CreateUserDTO>().ReverseMap();
                CreateMap<User, UpdateUserDTO>().ReverseMap();
                
                

            }
        }
    }
}
