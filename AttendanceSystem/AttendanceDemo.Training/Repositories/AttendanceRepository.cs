﻿using AttendanceDemo.Data;
using AttendanceDemo.Training.Contexts;
using AttendanceDemo.Training.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Training.Repositories
{
    public class AttendanceRepository : Repository<Attendance>
    {
        public AttendanceRepository(TrainingDbContext context)
            : base(context)
        {

        }
    }
}
