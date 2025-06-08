using System.Linq;
using System.Web.Mvc;
using SehirTanitim.Models;


namespace SehirTanitim.Controllers
{
    public class AdminController : Controller
    {
        MyDbContext db = new MyDbContext();

        private bool IsAdmin()
        {
            return Session["UserRole"] != null && Session["UserRole"].ToString() == "Admin";
        }

        private ActionResult UnauthorizedRedirect()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult SliderList() => IsAdmin() ? View(db.SliderImages.ToList()) : UnauthorizedRedirect();

        public ActionResult CreateSlider() => IsAdmin() ? View() : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult CreateSlider(SliderImage s)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            if (ModelState.IsValid)
            {
                db.SliderImages.Add(s);
                db.SaveChanges();
                return RedirectToAction("SliderList");
            }
            return View(s);
        }

        public ActionResult EditSlider(int id) => IsAdmin() ? View(db.SliderImages.Find(id)) : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult EditSlider(SliderImage s)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            db.Entry(s).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("SliderList");
        }
        public ActionResult DeleteSlider(int id)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            var s = db.SliderImages.Find(id);
            db.SliderImages.Remove(s);
            db.SaveChanges();
            return RedirectToAction("SliderList");
        }

        public ActionResult DistrictList() => IsAdmin() ? View(db.Districts.ToList()) : UnauthorizedRedirect();
        public ActionResult CreateDistrict() => IsAdmin() ? View() : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult CreateDistrict(District d)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            db.Districts.Add(d);
            db.SaveChanges();
            return RedirectToAction("DistrictList");
        }

        public ActionResult EditDistrict(int id) => IsAdmin() ? View(db.Districts.Find(id)) : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult EditDistrict(District d)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            db.Entry(d).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("DistrictList");
        }

        public ActionResult DeleteDistrict(int id)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            var d = db.Districts.Find(id);
            db.Districts.Remove(d);
            db.SaveChanges();
            return RedirectToAction("DistrictList");
        }

        public ActionResult PopulationList() => IsAdmin() ? View(db.Populations.ToList()) : UnauthorizedRedirect();
        public ActionResult CreatePopulation() => IsAdmin() ? View() : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult CreatePopulation(Population p)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            db.Populations.Add(p);
            db.SaveChanges();
            return RedirectToAction("PopulationList");
        }

        public ActionResult EditPopulation(int id) => IsAdmin() ? View(db.Populations.Find(id)) : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult EditPopulation(Population p)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("PopulationList");
        }

        public ActionResult DeletePopulation(int id)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            var p = db.Populations.Find(id);
            db.Populations.Remove(p);
            db.SaveChanges();
            return RedirectToAction("PopulationList");
        }

        public ActionResult TouristPlaceList() => IsAdmin() ? View(db.TouristPlaces.ToList()) : UnauthorizedRedirect();
        public ActionResult CreateTouristPlace() => IsAdmin() ? View() : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult CreateTouristPlace(TouristPlace t)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            db.TouristPlaces.Add(t);
            db.SaveChanges();
            return RedirectToAction("TouristPlaceList");
        }

        public ActionResult EditTouristPlace(int id) => IsAdmin() ? View(db.TouristPlaces.Find(id)) : UnauthorizedRedirect();
        [HttpPost]
        public ActionResult EditTouristPlace(TouristPlace t)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("TouristPlaceList");
        }

        public ActionResult DeleteTouristPlace(int id)
        {
            if (!IsAdmin()) return UnauthorizedRedirect();
            var t = db.TouristPlaces.Find(id);
            db.TouristPlaces.Remove(t);
            db.SaveChanges();
            return RedirectToAction("TouristPlaceList");
        }
    }
}
