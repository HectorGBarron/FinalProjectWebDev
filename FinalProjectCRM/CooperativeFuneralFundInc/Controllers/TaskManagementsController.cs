using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using CooperativeFuneralFundInc.Models.TasksManagement;
using CooperativeFuneralFundInc.Models.DropDownMenu;
using CooperativeFuneralFundInc.Models.UserManagement;

namespace CooperativeFuneralFundInc.Controllers
{
    public class TaskManagementsController : Controller
    {
        private readonly CFFDataContext _context;

        public TaskManagementsController(CFFDataContext context)
        {
            _context = context;
        }

        // GET: TaskManagements
        public async Task<IActionResult> Index()
        {
            var cFFDataContext = _context.TaskManagements.Include(t => t.OwnerName).Include(t => t.RequestTypeDescription).Include(t => t.StatusName);
            return View(await cFFDataContext.ToListAsync());
        }

        // GET: TaskManagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagements
                .Include(t => t.OwnerName)
                .Include(t => t.RequestTypeDescription)
                .Include(t => t.StatusName)
                .FirstOrDefaultAsync(m => m.TaskManagementId == id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            return View(taskManagement);
        }

        // GET: TaskManagements/Create
        public IActionResult Create()
        {
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID");
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID");
            ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "StatusID", "StatusID");
            return View();
        }

        // POST: TaskManagements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskManagementId,StatusID,OwnerID,RelatedTo,RelatedToName,RequestTypeID,Priority,CreateBy,CreatedTime,UpdatedBy,UpdatedTime")] TaskManagement taskManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID", taskManagement.OwnerID);
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID", taskManagement.RequestTypeID);
            ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "StatusID", "StatusID", taskManagement.StatusID);
            return View(taskManagement);
        }

        // GET: TaskManagements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagements.FindAsync(id);
            if (taskManagement == null)
            {
                return NotFound();
            }
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID", taskManagement.OwnerID);
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID", taskManagement.RequestTypeID);
            ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "StatusID", "StatusID", taskManagement.StatusID);
            return View(taskManagement);
        }

        // POST: TaskManagements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskManagementId,StatusID,OwnerID,RelatedTo,RelatedToName,RequestTypeID,Priority,CreateBy,CreatedTime,UpdatedBy,UpdatedTime")] TaskManagement taskManagement)
        {
            if (id != taskManagement.TaskManagementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskManagementExists(taskManagement.TaskManagementId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID", taskManagement.OwnerID);
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID", taskManagement.RequestTypeID);
            ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "StatusID", "StatusID", taskManagement.StatusID);
            return View(taskManagement);
        }

        // GET: TaskManagements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagements
                .Include(t => t.OwnerName)
                .Include(t => t.RequestTypeDescription)
                .Include(t => t.StatusName)
                .FirstOrDefaultAsync(m => m.TaskManagementId == id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            return View(taskManagement);
        }

        // POST: TaskManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskManagement = await _context.TaskManagements.FindAsync(id);
            _context.TaskManagements.Remove(taskManagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskManagementExists(int id)
        {
            return _context.TaskManagements.Any(e => e.TaskManagementId == id);
        }
    }
}
