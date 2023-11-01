using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using SaleWeb.ViewModels;

namespace SaleWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MemberManagementController : Controller
    {
        private MemberRepository memberRepository = new MemberRepository();

        public IActionResult Index()
        {
            IEnumerable<Member> memberList = memberRepository.GetMembers();
            return View(memberList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MemberId,Email,CompanyName,City,Country,Password")] CreateMemberViewModel member)
        {
            Member m = new Member()
            {
                Email = member.Email,
                CompanyName = member.CompanyName,
                City = member.City,
                Country = member.Country,
                Password = member.Password,
            };

            if (ModelState.IsValid)
            {
                memberRepository.CreateMember(m);
                return RedirectToAction(nameof(Index));
            }

            return View(member);
        }

        [HttpGet]
        public IActionResult Edit(string email)
        {
            Member member = memberRepository.GetMemberByEmail(email);
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit([FromForm] Member member)
        {
            Member MemUpdate = memberRepository.GetMemberByEmail(member.Email);
            MemUpdate.Email = member.Email;
            MemUpdate.CompanyName = member.CompanyName;
            MemUpdate.City = member.City;
            MemUpdate.Country = member.Country;
            MemUpdate.Password = member.Password;
            memberRepository.UpdateMember(MemUpdate);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(string email)
        {
            Member member = memberRepository.GetMemberByEmail(email);
            return View(member);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteMember([FromForm] string email)
        {
            memberRepository.DeleteMember(email);
            return RedirectToAction(nameof(Index));
        }
    }
}