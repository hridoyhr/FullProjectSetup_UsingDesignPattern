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
        public IRepository<Attendance> Attendances { get; private set; }

        public IRepository<Student> Students { get; private set; }

        public TrainingUnitOfWork(TrainingDbContext context) : base(context)
        {
            Attendances = new AttendanceRepository(context);
            Students = new StudentRepository(context);
        }
    }
}
