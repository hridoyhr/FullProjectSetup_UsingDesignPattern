using AttendanceDemo.Training.Services;
using System;
using Autofac;
using AttendanceDemo.Training.BusinessObjects;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class CreateCourseModel
    {
        public string Title { get; set; }

        public int Fees { get; set; }

        public DateTime StartDate { get; set; }


        private readonly ICourseService _courseService;

        public CreateCourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public CreateCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        internal void CreateCourse()
        {
            var course = new Course
            {
                Title = Title,
                Fees = Fees,
                StartDate = StartDate
            };

            _courseService.CreateCourse(course);
        }
    }
}
