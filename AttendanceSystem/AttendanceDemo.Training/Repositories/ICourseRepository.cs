using AttendanceDemo.Data;
using AttendanceDemo.Training.Entities;
using FirstDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.Repositories
{
    public interface ICourseRepository : IRepository<Course, int>
    {
    }
}
