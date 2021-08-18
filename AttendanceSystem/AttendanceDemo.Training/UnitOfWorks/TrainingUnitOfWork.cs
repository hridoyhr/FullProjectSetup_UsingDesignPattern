using AttendanceDemo.Data;
using AttendanceDemo.Training.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.UnitOfWorks
{
    public class TrainingUnitOfWork<T> : UnitOfWork where T : DbContext
    {
        public IRepository<Student> Students { get; private set; }

        public IRepository<Attendance> Attendances { get; private set; }

        public TrainingUnitOfWork(T context) : base(context)
        {
        }
    }
}
