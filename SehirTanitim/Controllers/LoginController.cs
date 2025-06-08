using System.Linq;
using System.Web.Mvc;
using SehirTanitim.Models;

namespace SehirTanitim.Controllers
{
    public class LoginController : Controller
    {
        MyDbContext db = new MyDbContext();

        // Giriş Sayfası
        public ActionResult Index() => View();

        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                Session["UserId"] = user.Id;
                Session["UserRole"] = user.Role;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "E-posta veya şifre hatalı";
            return View();
        }

        // Kayıt Sayfası
        public ActionResult Register() => View();

        [HttpPost]
        public ActionResult Register(User u)
        {
            if (ModelState.IsValid)
            {
                u.Role = "User";
                db.Users.Add(u);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(u);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
