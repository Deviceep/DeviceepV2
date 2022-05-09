using Deviceep.Core.Repositories;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Deviceep.Data.UnitOfWorks
{

    public class UnitOfWorks : IUnitOfWork
    {

        // Definition of existing Entity Models 
        // In our Database

        private readonly AppDbContext _context;
        private AttendanceHourRepository _AttendanceHours;
        private AttendanceRepository _Attendances;
        private ClassroomRepository _Classrooms;
        private CourseRepository _Courses;
        private CourseClassroomRepository _CourseClassrooms;

        private CourseTimeInfoRepository _CourseTimeInfos;
        private CourseTimeInfoCourseRepository _courseTimeInfoCourses;
        private DepartmentRepository _Departments;
        private EnrollmentRepository _Enrollments;
        private FacultyRepository _Facultys;
        private UserRepository _Users;
        private UserDepartmentRepository _UserDepartments;


        // Connection Between Repository's and Entities

        public IAttendanceHourRepository AttendanceHours => _AttendanceHours = _AttendanceHours ?? new AttendanceHourRepository(_context);

        public IAttendanceRepository Attendances => _Attendances = _Attendances ?? new AttendanceRepository(_context);

        public IClassroomRepository Classrooms => _Classrooms = _Classrooms ?? new ClassroomRepository(_context);

        public ICourseRepository Courses => _Courses = _Courses ?? new CourseRepository(_context);

        

        public ICourseTimeInfoRepository CourseTimes => _CourseTimeInfos = _CourseTimeInfos ?? new CourseTimeInfoRepository(_context);
        

        public IDepartmentRepository Departments => _Departments = _Departments ?? new DepartmentRepository(_context);

        public IEnrollmentRepository Enrollments => _Enrollments = _Enrollments ?? new EnrollmentRepository(_context);

        public IFacultyRepository Facultys => _Facultys = _Facultys ?? new FacultyRepository(_context);

        public IUserRepository Users => _Users = _Users ?? new UserRepository(_context);
        public IUserDepartmentRepository UserDepartments => _UserDepartments = _UserDepartments ?? new UserDepartmentRepository(_context);

        public ICourseClassroomRepository courseClassroomRepositorys => _CourseClassrooms = _CourseClassrooms ?? new CourseClassroomRepository(_context);

        public ICourseTimeInfoCourseRepository courseTimeInfoCourseRepository => _courseTimeInfoCourses = _courseTimeInfoCourses ?? new CourseTimeInfoCourseRepository(_context);

        public UnitOfWorks(AppDbContext context)
        {
            _context = context;
        }
      
        public void Commit()
        {
            _context.SaveChanges();
        }

        // Saving to the database
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        // Eliminating the unnecessary information in the memory
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
