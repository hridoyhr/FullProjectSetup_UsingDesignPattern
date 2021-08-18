using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Services
{
    public class SimpleDatabaseServices : IDatabaseService
    {
        private IDriverService _driverService;

        public SimpleDatabaseServices(IDriverService driverService)
        {
            _driverService = driverService;
        }
        public string getName()
        {
            return "SimpleDatabaseServices";
        }
    }
}
