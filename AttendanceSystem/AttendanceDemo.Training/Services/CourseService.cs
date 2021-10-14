using AttendanceDemo.Common.Utilities;
using AttendanceDemo.Training.BusinessObjects;
using AttendanceDemo.Training.Exceptions;
using AttendanceDemo.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AttendanceDemo.Training.Services
{
    public class CourseService : ICourseService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IDateTimeUtility _dateTimeUtility;

        public CourseService(ITrainingUnitOfWork trainingUnitOfWork,
            IDateTimeUtility dateTimeUtility)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _dateTimeUtility = dateTimeUtility;
        }
        public IList<Course> GetAllCourses()
        {
            var courseEntites = _trainingUnitOfWork.Courses.GetAll(); 
            var courses = new List<Course>();

            foreach(var entity in courseEntites)
            {
                var course = new Course()
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Fees = entity.Fees,
                    StartDate = entity.StartDate
                };

                courses.Add(course);
            }

            return courses;
        }

        public void CreateCourse(Course course)
        {
            if (course == null)
                throw new InvalidParameterException("Course was not provided");

            if (IsTitleAlreadyUsed(course.Title))
                throw new DuplicateTitleException("Course Title already exists");

            if (!IsValidStartDate(course.StartDate))
                throw new InvalidOperationException("Start date should be atleast 30 days ahead");

            _trainingUnitOfWork.Courses.Add(
                new Entities.Course
                {
                    Title = course.Title,
                    Fees = course.Fees,
                    StartDate = course.StartDate
                }

                );
            //unit of work + repository
            _trainingUnitOfWork.Save();


        }

        public void EnrollStudent(Course course, Student student)
        {
            var courseEntity = _trainingUnitOfWork.Courses.GetById(course.Id);

            if (courseEntity == null)
                throw new InvalidOperationException("Course was not found");

            if (courseEntity.EnrolledStudents == null)
                courseEntity.EnrolledStudents = new List<Entities.CourseStudents>();

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

        private bool IsTitleAlreadyUsed(string title) =>
            _trainingUnitOfWork.Courses.GetCount(x => x.Title == title) > 0;

        private bool IsValidStartDate(DateTime startDate) =>
            startDate.Subtract(_dateTimeUtility.Now).TotalDays > 30;

        public (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex, int pageSize, 
            string searchText, string sortText)
        {
            //using ternary operator
            var courseData = _trainingUnitOfWork.Courses.GetDynamic(
                string.IsNullOrWhiteSpace(searchText) ? null : x => x.Title.Contains(searchText),
                sortText, string.Empty, pageIndex, pageSize);

            var resultData = (from course in courseData.data
                              select new Course
                              {
                                  Id = course.Id,
                                  Title = course.Title,
                                  Fees = course.Fees,
                                  StartDate = course.StartDate
                              }).ToList();
            return (resultData, courseData.total, courseData.totalDisplay);                 
        }
    }
}
