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
    public class CourseService : ICourseService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;

        public CourseService(ITrainingUnitOfWork trainingUnitOfWork)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
        }
        public IList<BusinessObjects.Course> GetAllCourses()
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

            //unit of work + repository
            _trainingUnitOfWork.Save();
        } 

        public void EnrolledStudent(Course course, BusinessObjects.Student student)
        {
            var courseEntity = _trainingUnitOfWork.Courses.GetById(course.Id);

            if (courseEntity == null)
                throw new InvalidOperationException("Course was not found");

            if (courseEntity.EnrolledStudents == null)
                courseEntity.EnrolledStudents = new List<CourseStudents>();

            courseEntity.EnrolledStudents.Add(new Entities.CourseStudents
            {
                Student = new Entities.Student
                { 
                    Name = student.Name,
                    DateOfBirth = student.DateOfBirth
                }
            });

            _trainingUnitOfWork.Save();
        }
    }
}
