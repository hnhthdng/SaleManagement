using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;

namespace SaleWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly MemberRepository memberRepository = new MemberRepository();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] string email, string password)
        {
            Member ad = getAdmin();
            IEnumerable<Member> memberList = memberRepository.GetMembers();
            ViewBag.memberList = memberList;
            // Basic login validation (replace with your authentication logic)
            foreach (var member in memberList)
            {
                if (email == ad.Email && password == ad.Password)
                {
                    HttpContext.Session.SetString("Username", email); // Store username in session
                    HttpContext.Session.SetString("Role", "isAdmin"); // Store Role in session
                    return RedirectToAction("Index", "Home"); // Redirect to the home page or another page after login
                }

                if (email == member.Email && password == member.Password)
                {
                    HttpContext.Session.SetString("Username", email); // Store username in session
                    HttpContext.Session.SetString("Role", "isMember"); // Store username in session
                    return RedirectToAction("Index", "Home"); // Redirect to the home page or another page after login
                }
            }
            // Login failed
            ModelState.AddModelError(string.Empty, "Invalid login attempt");
            return View();
        }

        private Member getAdmin()
        {
            string json = string.Empty;
            using (StreamReader reader = new StreamReader("D:\\Major\\Kì 5\\PRN211\\Code\\SaleManagement\\SaleWebApp\\appsettings.json"))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var obj = jss.Deserialize<dynamic>(json);
            var admin = new Member()
            {
                Email = obj["DefaultAccount"]["Email"],
                Password = obj["DefaultAccount"]["Password"]
            };
            return admin;
        }
    }
}