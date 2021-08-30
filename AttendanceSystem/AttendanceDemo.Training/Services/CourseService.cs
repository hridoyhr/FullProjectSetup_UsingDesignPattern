using AttendanceDemo.Training.Contexts;
using AttendanceDemo.Training.Entities;
using AttendanceDemo.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.Services
{
    public class CourseService : IStudentService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;

        public CourseService(ITrainingUnitOfWork trainingUnitOfWork)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
        }
        public IList<BusinessObjects.Course> GetAllStudents()
        {
            var courseEntites = _trainingUnitOfWork.Courses.GetAll();
            var courses = new List<BusinessObjects.Course>();

            foreach(var entity in courseEntites)
            {
                var course = new BusinessObjects.Course()
                {
                    Title = entity.Title,
                    Fees = entity.Fees,
                    StartDate = entity.StartDate,
                };

                courses.Add(course);
            }

            return courses;
        }

        public void CreateCourse(Course course)
        {
            _trainingUnitOfWork.Courses.Add(
                new Entities.Course
                {
                    Id = course.Id,
                    Title = course.Title,
                    Fees = course.Fees,
                    StartDate = course.StartDate,
                }
             );

            _trainingUnitOfWork.Courses.Add(
                new Entities.Course
                {

                }
              );

            //unit of work + repository
            _trainingUnitOfWork.Save();
        }
    }
}
