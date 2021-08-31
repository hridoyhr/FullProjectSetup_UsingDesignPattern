using AttendanceDemo.Training.BusinessObjects;
using AttendanceDemo.Training.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class CourseListModel
    {
        private ICourseService _courseService;

        public IList<Course> Courses { get; set; }

        public CourseListModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public CourseListModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void LoadModelData()
        {
            Courses = _courseService.GetAllCourses();
        }
    }
}
