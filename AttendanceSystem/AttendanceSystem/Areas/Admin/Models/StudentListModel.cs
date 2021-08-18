using AttendanceDemo.Training.BusinessObjects;
using AttendanceDemo.Training.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class StudentListModel
    {
        private IStudentService _studentService;

        public IList<Student> Students { get; set; }

        public StudentListModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        public StudentListModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void LoadModelData()
        {
            Students = _studentService.GetAllStudents();
        }
    }
}
