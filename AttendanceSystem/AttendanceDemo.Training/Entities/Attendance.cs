using FirstDemo.Data;
using System;

namespace AttendanceDemo.Training.Entities
{
    public class Attendance : IEntity<int>
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public DateTime Date { get; set; }
    }
}
