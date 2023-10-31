using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

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
    }
}