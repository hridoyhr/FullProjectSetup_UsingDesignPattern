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
    public class StudentService : IStudentService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;

        public StudentService(ITrainingUnitOfWork trainingUnitOfWork)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
        }
        public IList<BusinessObjects.Student> GetAllStudents()
        {
            var studentEntities = _trainingUnitOfWork.Students.GetAll();
            var students = new List<BusinessObjects.Student>();

            foreach(var entity in studentEntities)
            {
                var student = new BusinessObjects.Student()
                {
                    Name = entity.Name,
                    StudentRollNumber = entity.StudentRollNumber
                };

                students.Add(student);
            }

            return students;
        }

        public void CreateStudent(Student student)
        {
            _trainingUnitOfWork.Students.Add(
                new Entities.Student
                {
                    Id = student.Id,
                    Name = student.Name,
                    StudentRollNumber = student.StudentRollNumber
                }
             );

            _trainingUnitOfWork.Attendances.Add(
                new Entities.Attendance
                {

                }
              );

            //unit of work + repository
            _trainingUnitOfWork.Save();
        }
    }
}
