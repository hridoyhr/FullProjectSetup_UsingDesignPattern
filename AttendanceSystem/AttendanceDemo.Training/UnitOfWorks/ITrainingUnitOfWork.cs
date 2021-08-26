using AttendanceDemo.Data;
using AttendanceDemo.Training.Entities;

namespace AttendanceDemo.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork : IUnitOfWork
    {
        IRepository<Attendance> Attendances { get; }
        IRepository<Student> Students { get; }
    }
}