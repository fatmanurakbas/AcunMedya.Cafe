// FooterController.cs gibi bir controller oluştur
using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;

public class FooterController : Controller
{
    private readonly CafeContext _context;

    public FooterController(CafeContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Subscribe(string email)
    {
        if (!string.IsNullOrEmpty(email))
        {
            var abonelik = new Abonelik { Email = email };
            _context.Aboneliks.Add(abonelik);
            _context.SaveChanges();
        }

        return RedirectToAction("Index", "Home");
    }
}
