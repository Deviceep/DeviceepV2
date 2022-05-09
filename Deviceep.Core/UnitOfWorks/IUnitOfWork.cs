using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Deviceep.Core.Repositories;

namespace Deviceep.Core.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable 
    {
        IAttendanceHourRepository AttendanceHours { get; }
        IAttendanceRepository Attendances { get; }
        IClassroomRepository Classrooms { get; }
        ICourseRepository Courses { get; }
        IEnrollmentRepository Enrollments { get; }
        ICourseClassroomRepository courseClassroomRepositorys { get; }
        ICourseTimeInfoCourseRepository courseTimeInfoCourseRepository { get; }
        ICourseTimeInfoRepository CourseTimes { get; }
        IDepartmentRepository Departments { get; }
        IFacultyRepository Facultys { get; }
        IUserRepository Users { get; }
        IUserDepartmentRepository UserDepartments { get; }
        
        

        Task CommitAsync();

        void Commit();

    }
}
