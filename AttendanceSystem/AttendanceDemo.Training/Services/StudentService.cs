using AttendanceDemo.Training.BusinessObjects;
using AttendanceDemo.Training.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.Services
{
    public class StudentService : IStudentService
    {
        private readonly TrainingDbContext _trainingDbContext;

        public StudentService(TrainingDbContext trainingDbContext)
        {
            _trainingDbContext = trainingDbContext;
        }
        public IList<Student> GetAllStudents()
        {
            var studentEntities = _trainingDbContext.Students.ToList();
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
            _trainingDbContext.Students.Add(
                new Entities.Student
                {
                    Name = student.Name,
                    StudentRollNumber = student.StudentRollNumber
                }
             );

            //unit of work + repository
            _trainingDbContext.SaveChanges();
        }
    }
}
