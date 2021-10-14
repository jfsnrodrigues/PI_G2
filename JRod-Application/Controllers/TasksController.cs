using JRod_Application.Enums;
using JRod_Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRod_Application.Controllers
{
    public class TasksController : Controller
    {
        readonly ITaskServices _services;
        readonly IUserServices _userServices;
        public TasksController(ITaskServices services, IUserServices userServices)
        {
            _services = services;
            _userServices = userServices;
        }

        // GET: Tasks
        public async Task<IActionResult> Index(int userId = 0)
        {
            IEnumerable<Models.Task> tasks = _services.GetAll();

            if (userId != 0)
                tasks = tasks.Where(x => x.UserId == userId);

            IEnumerable<IGrouping<JRodTasksStatus, Models.Task>> groupedTasks =
                tasks.GroupBy(x => x.Status);

            ViewBag.Statuses = Enum.GetValues(typeof(JRodTasksStatus));

            IEnumerable<Models.User> users = _userServices.GetAll();

            var options = new List<SelectListItem>
            {
                new SelectListItem {
                    Text = "All",
                    Value = "0",
                    Selected = ( userId == 0) }
            };

            options.AddRange(users
                .Select(x =>
                    new SelectListItem
                    {
                        Text = $"{x.Name}",
                        Value = x.UserId.ToString(),
                        Selected = userId == x.UserId
                    }));

            ViewBag.Users = options;

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
        public async Task<IActionResult> Create([Bind("TaskId,Title,Description,Status,UserId")] Models.Task task)
        {
            if (!ModelState.IsValid)
                return View(task);

            try
            {
                _services.Add(task);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }


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
