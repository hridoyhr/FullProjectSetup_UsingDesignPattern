using System;
using AttendanceDemo.Training.BusinessObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.Services
{
    public interface ICourseService
    {
        IList<Course> GetAllCourses();

        void EnrollStudent(Course course, Student student);
    }
}
