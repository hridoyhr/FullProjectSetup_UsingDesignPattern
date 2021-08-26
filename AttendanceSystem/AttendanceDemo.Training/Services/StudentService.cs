using AttendanceDemo.Training.BusinessObjects;
using AttendanceDemo.Training.Contexts;
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
        public IList<Student> GetAllStudents()
        {
            var studentEntities = _trainingUnitOfWork.Students.GetAll();
            var students = new List<Student>();

            foreach(var entity in studentEntities)
            {
                var student = new Student()
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
                    Name = student.Name,
                    StudentRollNumber = student.StudentRollNumber
                }
             );

            //unit of work + repository
            _trainingUnitOfWork.Save();
        }
    }
}
