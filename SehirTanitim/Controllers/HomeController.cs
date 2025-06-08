using System.Linq;
using System.Web.Mvc;
using SehirTanitim.Models;

namespace SehirTanitim.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext db = new MyDbContext();

        public ActionResult Index()
        {
            ViewBag.SehirTanitimi = "Eskişehir, Türkiye’nin İç Anadolu Bölgesi’nde yer alan, köklü tarihi, gelişmiş sanayisi ve modern şehir yapısıyla dikkat çeken önemli bir yerleşim merkezidir. Osmanlı dönemine ait mimari dokusunu günümüze kadar koruyan Odunpazarı evleriyle kültürel bir miras sunarken, Porsuk Çayı çevresinde yer alan kafe ve yürüyüş alanlarıyla da sosyal yaşama canlılık katmaktadır. Anadolu Üniversitesi ve Eskişehir Teknik Üniversitesi sayesinde genç nüfus oranı oldukça yüksek olan şehir, öğrenci dostu yapısıyla eğitim ve kültür alanında öne çıkmaktadır. Ayrıca Sazova Bilim Kültür ve Sanat Parkı, Balmumu Heykeller Müzesi ve Lületaşı Müzesi gibi turistik noktalarıyla yıl boyunca pek çok ziyaretçiyi ağırlamaktadır. Gelişmiş toplu taşıma sistemi, çevreye duyarlı yaşam biçimi ve sanatla iç içe yapısıyla Eskişehir, Türkiye’nin yaşanabilir en modern şehirlerinden biri olarak değerlendirilmektedir.";
            var slider = db.SliderImages.ToList();
            return View(slider);
        }
       
        public ActionResult Nufus()
        {
            var data = db.Populations.OrderByDescending(x => x.Year).ToList();
            return View(data);
        }
        
        public ActionResult Ilceler()
        {
            var data = db.Districts.Take(6).ToList();
            return View(data);
        }
      
        public ActionResult TuristikYerler()
        {
            var data = db.TouristPlaces.Take(6).ToList();
            return View(data);
        }
        
        public ActionResult Hakkimizda()
        {
            if (Session["UserRole"]?.ToString() == "Admin")
                return RedirectToAction("Index");
            return View();
        }
    }
}
