using AttendanceDemo.Data;
using AttendanceDemo.Training.Contexts;
using AttendanceDemo.Training.Entities;
using AttendanceDemo.Training.Repositories;

namespace AttendanceDemo.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork : IUnitOfWork
    {
        ICourseRepository Courses { get; }
        IStudentRepository Students { get; }
    }
}