using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace SaleWeb.Controllers
{
    public class ProfileController : Controller
    {
        private MemberRepository memberRepository = new MemberRepository();

        public IActionResult Index()
        {
            string email = HttpContext.Session.GetString("Username");
            Member member = memberRepository.GetMemberByEmail(email);
            return View(member);
        }

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
    }
}