using JRod_Application.Enums;
using JRod_Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRod_Application.Controllers
{
    public class TasksController : Controller
    {
        ITaskServices _services;
        public TasksController(ITaskServices services)
        {
            _services = services;
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
            IEnumerable<IGrouping<JRodTasksStatus, Models.Task>> groupedTasks =
                _services.GetAll().GroupBy(x => x.Status);

            ViewBag.Statuses = Enum.GetValues(typeof(JRodTasksStatus));
            
            return View(groupedTasks);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskId,Title,Description,Status")] Models.Task task)
        {
            if (!ModelState.IsValid)
                return View(task);

            _services.Add(task);

            return RedirectToAction("Index", "Home");
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var task = _services.Get(id.GetValueOrDefault());

            if (task == null)
                return NotFound();

            _services.Delete(id.GetValueOrDefault());

            return RedirectToAction("Index", "Home");
        }
    }
}
