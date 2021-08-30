using AttendanceDemo.Data;
using AttendanceDemo.Training.Contexts;
using AttendanceDemo.Training.Entities;
using AttendanceDemo.Training.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AttendanceDemo.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public ICourseRepository Courses { get; private set; }

        public IStudentRepository Students { get; private set; }

        public TrainingUnitOfWork(ITrainingDbContext context,
            ICourseRepository courses,
            IStudentRepository students
            ) : base((DbContext)context)
        {
            Courses = courses;
            Students = students;
        }
    }
}
 