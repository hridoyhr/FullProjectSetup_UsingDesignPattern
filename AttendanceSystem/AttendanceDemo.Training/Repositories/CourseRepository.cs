using AttendanceDemo.Data;
using AttendanceDemo.Training.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.Repositories
{
    public class CourseRepository : Repository<Course, int>, 
        ICourseRepository
    {
        public CourseRepository(ITrainingDbContext context)
            : base((DbContext)context)
        {
        }
    }
}
