using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CooperativeFuneralFundInc.Models.DropDownMenu;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CooperativeFuneralFundInc.Areas.Admin.Controllers

{
    [Authorize(Roles = "Admin, Members")]
    [Area("Admin")]
    public class SupplyRequestsController : Controller
    {
        private readonly CFFDataContext _context;

        public SupplyRequestsController(CFFDataContext context)
        {
            _context = context;
        }

        // GET: Admin/SupplyRequests
        public async Task<IActionResult> Index()
        {
            var cFFDataContext = _context.SupplyRequests.Include(s => s.Client).Include(s => s.OrderItems).Include(s => s.Owner).Include(s => s.RequestTypeDescription).Include(s => s.Status).Include(s => s.SupplyRequestOrigin);
            return View(await cFFDataContext.ToListAsync());
        }

        // GET: Admin/SupplyRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplyRequest = await _context.SupplyRequests
                .Include(s => s.Client)
                .Include(s => s.OrderItems)
                .Include(s => s.Owner)
                .Include(s => s.RequestTypeDescription)
                .Include(s => s.Status)
                .Include(s => s.SupplyRequestOrigin)
                .FirstOrDefaultAsync(m => m.SupplyRequestId == id);
            if (supplyRequest == null)
            {
                return NotFound();
            }

            return View(supplyRequest);
        }

        // GET: Admin/SupplyRequests/Create
        public IActionResult Create()
        {
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierID");
            ViewData["OrderItemsID"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsID");
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID");
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID");
            ViewData["StatusID"] = new SelectList(_context.Statuses, "StatusID", "StatusID");
            ViewData["RequestOriginId"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginId");
            return View();
        }

        // POST: Admin/SupplyRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplyRequestId,StatusID,StatusComments,OrderItemsID,RequestOriginId,RequestTypeID,ClientSupplierID,OwnerID,CreatedBy,CreateTime,UpdatedBy,UpdatedTime")] SupplyRequest supplyRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplyRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierID", supplyRequest.ClientSupplierID);
            ViewData["OrderItemsID"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsID", supplyRequest.OrderItemsID);
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID", supplyRequest.OwnerID);
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID", supplyRequest.RequestTypeID);
            ViewData["StatusID"] = new SelectList(_context.Statuses, "StatusID", "StatusID", supplyRequest.StatusID);
            ViewData["RequestOriginId"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginId", supplyRequest.RequestOriginId);
            return View(supplyRequest);
        }

        // GET: Admin/SupplyRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplyRequest = await _context.SupplyRequests.FindAsync(id);
            if (supplyRequest == null)
            {
                return NotFound();
            }
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierID", supplyRequest.ClientSupplierID);
            ViewData["OrderItemsID"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsID", supplyRequest.OrderItemsID);
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID", supplyRequest.OwnerID);
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID", supplyRequest.RequestTypeID);
            ViewData["StatusID"] = new SelectList(_context.Statuses, "StatusID", "StatusID", supplyRequest.StatusID);
            ViewData["RequestOriginId"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginId", supplyRequest.RequestOriginId);
            return View(supplyRequest);
        }

        // POST: Admin/SupplyRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplyRequestId,StatusID,StatusComments,OrderItemsID,RequestOriginId,RequestTypeID,ClientSupplierID,OwnerID,CreatedBy,CreateTime,UpdatedBy,UpdatedTime")] SupplyRequest supplyRequest)
        {
            if (id != supplyRequest.SupplyRequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplyRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplyRequestExists(supplyRequest.SupplyRequestId))
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
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierID", supplyRequest.ClientSupplierID);
            ViewData["OrderItemsID"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsID", supplyRequest.OrderItemsID);
            ViewData["OwnerID"] = new SelectList(_context.OwnerNames, "OwnerID", "OwnerID", supplyRequest.OwnerID);
            ViewData["RequestTypeID"] = new SelectList(_context.SupplyRequestTypes, "RequestTypeID", "RequestTypeID", supplyRequest.RequestTypeID);
            ViewData["StatusID"] = new SelectList(_context.Statuses, "StatusID", "StatusID", supplyRequest.StatusID);
            ViewData["RequestOriginId"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginId", supplyRequest.RequestOriginId);
            return View(supplyRequest);
        }

        // GET: Admin/SupplyRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplyRequest = await _context.SupplyRequests
                .Include(s => s.Client)
                .Include(s => s.OrderItems)
                .Include(s => s.Owner)
                .Include(s => s.RequestTypeDescription)
                .Include(s => s.Status)
                .Include(s => s.SupplyRequestOrigin)
                .FirstOrDefaultAsync(m => m.SupplyRequestId == id);
            if (supplyRequest == null)
            {
                return NotFound();
            }

            return View(supplyRequest);
        }

        // POST: Admin/SupplyRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplyRequest = await _context.SupplyRequests.FindAsync(id);
            _context.SupplyRequests.Remove(supplyRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplyRequestExists(int id)
        {
            return _context.SupplyRequests.Any(e => e.SupplyRequestId == id);
        }
    }
}
