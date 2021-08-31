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
        private ICourseService _studentService;

        public IList<Course> Students { get; set; }

        public CourseListModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public CourseListModel(ICourseService studentService)
        {
            _studentService = studentService;
        }

        public void LoadModelData()
        {
            Students = _studentService.GetAllStudents();
        }
    }
}
