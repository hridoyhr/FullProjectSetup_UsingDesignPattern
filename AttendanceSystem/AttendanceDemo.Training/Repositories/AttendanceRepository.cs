using AttendanceDemo.Data;
using AttendanceDemo.Training.Contexts;
using AttendanceDemo.Training.Entities;

namespace AttendanceDemo.Training.Repositories
{
    public class AttendanceRepository : Repository<Attendance, int, TrainingDbContext>, IAttendanceRepository
    {
        public AttendanceRepository(TrainingDbContext context)
            : base(context)
        {

        }
    }
}
