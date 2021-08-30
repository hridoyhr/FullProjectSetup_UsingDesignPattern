using AttendanceDemo.Data;
using AttendanceDemo.Training.Contexts;
using AttendanceDemo.Training.Entities;
using AttendanceDemo.Training.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.UnitOfWorks
{
    public class AdoNetTrainingUnitOfWork : ITrainingUnitOfWork
    {
        public IRepository<Attendance, int> Attendances => throw new NotImplementedException();

        public IRepository<Student, int> Students => throw new NotImplementedException();

        IAttendanceRepository ITrainingUnitOfWork.Attendances => throw new NotImplementedException();

        IStudentRepository ITrainingUnitOfWork.Students => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
