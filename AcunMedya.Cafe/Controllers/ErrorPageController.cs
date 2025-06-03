using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Controllers
{
    public class ErrorPageController : Controller
    {
        [HttpGet]
        public IActionResult Page404()
        {
            // ViewModel yok, çünkü sabit veriler View'e direkt ViewBag üzerinden gönderiliyor.
            ViewBag.Heading = "Üzgünüz! Sayfa Bulunamadı";
            ViewBag.Content = "Aradığınız sayfa kaldırılmış, ismi değiştirilmiş veya geçici olarak kullanılamıyor olabilir.";
            ViewBag.ButtonText = "Anasayfaya Dön";

            return View();
        }
    }
}
