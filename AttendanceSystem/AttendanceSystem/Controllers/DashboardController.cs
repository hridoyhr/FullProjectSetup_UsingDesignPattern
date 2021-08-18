using AttendanceSystem.Models;
using AttendanceSystem.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Controllers
{
    public class DashboardController : Controller
    {
        private IDatabaseService _databaseService;
        public DashboardController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public IActionResult Summary()
        {
            var name = _databaseService.getName();

            var model = new SummaryModel();

            return View(model);
        }
    }
}
