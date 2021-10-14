using AttendanceDemo.Training.BusinessObjects;
using AttendanceDemo.Training.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class EditCourseModel
    {
        public int? Id { get; set; }

        public string Title { get; set; }

        public int? Fees { get; set; }

        public DateTime? StartDate { get; set; }


        private readonly ICourseService _courseService;
        public EditCourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }
        public void LoadModelData(int id)
        {
            var course = _courseService.GetCourses(id);
            Id = course?.Id;
            Title = course?.Title;
            Fees = course?.Fees;
            StartDate = course?.StartDate;
        }

        internal void Update()
        {
            var course = new Course
            {
                Id = Id.HasValue ? Id.Value : 0,
                Fees = Fees.HasValue ? Fees.Value : 0,
                Title = Title,
                StartDate = StartDate.HasValue ? StartDate.Value : DateTime.MinValue
            };
            _courseService.UpdateCourse(course);
        }
    }
}
