using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using SaleWeb.ViewModels;

namespace SaleWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderManagementController : Controller
    {
        private readonly MemberRepository memberRepository = new MemberRepository();
        private readonly OrderRepository orderRepository = new OrderRepository();
        private readonly AppDBContext _context = new AppDBContext();

        // GET: Admin/Orders
        public async Task<IActionResult> Index([FromQuery] string? desc)
        {
            if (desc == "desc")
            {
                var orderList = orderRepository.GetOrders().OrderByDescending(o => o.Freight).ToList();

                return View(orderList);
            }
            var list = _context.Orders.Include(o => o.Member);
            return View(await list.ToListAsync());
        }

        [HttpPost]
        public IActionResult Index([FromForm] DateTime? startDate, DateTime? endDate)
        {
            var orderList = orderRepository.GetOrders().Where(o => o.OrderTime >= startDate).Where(o => o.ShippedTime <= endDate).ToList();
            return View(orderList);
        }

        // GET: Admin/Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Member)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Admin/Orders/Create
        public IActionResult Create()
        {
            List<int> listMemberId = memberRepository.GetMembers().Select(m => m.MemberId).ToList();
            ViewData["MemberId"] = new SelectList(listMemberId);
            return View();
        }

        // POST: Admin/Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberId,OrderTime,RequiredTime,ShippedTime,Freight")] CreateOrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                Order o = new Order()
                {
                    MemberId = order.MemberId,
                    OrderTime = order.OrderTime,
                    RequiredTime = order.RequiredTime,
                    ShippedTime = order.ShippedTime,
                    Freight = order.Freight,
                };

                orderRepository.CreateOrder(o);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Admin/Orders/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            List<int> memberId = orderRepository.GetOrders().Select(o => o.MemberId).Distinct().ToList();
            Order order = orderRepository.GetOrderbyId(id);
            ViewData["MemberId"] = new SelectList(memberId, order.MemberId);
            return View(order);
        }

        // POST: Admin/Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,MemberId,OrderTime,RequiredTime,ShippedTime,Freight")] CreateOrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                Order oderUpdate = orderRepository.GetOrderbyId(order.OrderId);

                oderUpdate.MemberId = order.MemberId;
                oderUpdate.OrderTime = order.OrderTime;
                oderUpdate.RequiredTime = order.RequiredTime;
                oderUpdate.ShippedTime = order.ShippedTime;
                oderUpdate.Freight = order.Freight;

                orderRepository.UpdateOrder(oderUpdate);
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }

        // GET: Admin/Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Member)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Admin/Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_context.Orders == null)
            {
                return Problem("Entity set 'AppDBContext.Orders'  is null.");
            }

            orderRepository.DeleteOrder(id);

            return RedirectToAction(nameof(Index));
        }
    }
}