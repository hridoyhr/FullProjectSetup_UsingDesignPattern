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
        private IStudentService _studentService;

        public IList<Course> Students { get; set; }

        public CourseListModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        public CourseListModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void LoadModelData()
        {
            Students = _studentService.GetAllStudents();
        }
    }
}
