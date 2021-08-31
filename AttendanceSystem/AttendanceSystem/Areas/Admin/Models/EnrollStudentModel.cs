using AttendanceDemo.Training.BusinessObjects;
using AttendanceDemo.Training.Entities;
using AttendanceDemo.Training.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class EnrollStudentModel
    {
        public int StudentID { get; set; }
        
        public string CourseName { get; set; }

        private readonly ICourseService _courseService;

        public EnrollStudentModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public EnrollStudentModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void EnrollStudent()
        {
            var courses = _courseService.GetAllCourses();

            var selectedCourse = courses.Where(x => x.Title == CourseName).FirstOrDefault();

            var student = new AttendanceDemo.Training.BusinessObjects.Student
            {
                Id = StudentID,
                Name = "Hridoy",
                DateOfBirth = DateTime.Now
            };
            _courseService.EnrollStudent(selectedCourse, student);
        }
    }
}
