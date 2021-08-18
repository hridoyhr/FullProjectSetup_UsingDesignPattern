using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Models
{
    public class SummaryModel
    {
        public string summaryText { get; set; }

        public SummaryModel()
        {
            summaryText = "All Students Attendance sheet";
        }
    }
}
