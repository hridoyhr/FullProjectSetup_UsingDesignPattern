using AttendanceSystem.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            var model = new StudentListModel();
            model.LoadModelData();
            return View(model);
        }
    }
}
