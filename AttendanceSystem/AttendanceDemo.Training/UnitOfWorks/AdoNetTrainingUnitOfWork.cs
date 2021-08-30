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
        public IRepository<Course, int> Course => throw new NotImplementedException();

        public IRepository<Student, int> Student => throw new NotImplementedException();


        ICourseRepository ITrainingUnitOfWork.Courses => throw new NotImplementedException();

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
