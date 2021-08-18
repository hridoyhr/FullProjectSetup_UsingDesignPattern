using System;

namespace AttendanceDemo.Training.Entities
{
    public class Attendance
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public DateTime Date { get; set; }
    }
}
