using System;
using AttendanceDemo.Training.BusinessObjects;
using System.Collections.Generic;

namespace AttendanceDemo.Training.Services
{
    public interface ICourseService
    {
        IList<Course> GetAllCourses();

        void EnrollStudent(Course course, Student student);
        
        void CreateCourse(Course course);

        (IList<Course>records, int total, int totalDisplay) GetCourses(int pageIndex, int pageSize, 
            string searchText, string sortText);
    }
}
