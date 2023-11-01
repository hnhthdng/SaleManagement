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
using System.Collections;

namespace SaleWeb.Controllers
{
    public class OrdersController : Controller
    {
        public MemberRepository memberRepository = new MemberRepository();
        private AppDBContext dbContext = new AppDBContext();

        public OrdersController()
        {
        }

        public IActionResult Index()
        {
            Member _member = memberRepository.GetMemberByEmail(HttpContext.Session.GetString("Username"));
            var orderList = dbContext.Orders.Where(o => o.MemberId == _member.MemberId).ToList();
            return View(orderList);
        }
    }
}