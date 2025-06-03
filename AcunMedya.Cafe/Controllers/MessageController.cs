using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Controllers
{
    public class MessageController : Controller
    {
        private readonly CafeContext _context;

        public MessageController(CafeContext context)
        {
            _context = context;
        }

        // Tüm mesajları listeler
        public IActionResult Index()
        {
            var messages = _context.Messages.OrderByDescending(x => x.SendDate).ToList();
            return View(messages);
        }

        // Mesaj detayına gider
        public IActionResult DetailMessage(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null && !message.IsRead)
            {
                message.IsRead = true;
                _context.SaveChanges();
            }
            return View(message);
        }

        // Mesajı siler
        public IActionResult DeleteMessage(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // Mesaj ekleme (isteğe bağlı formdan gönderilirse)
        [HttpGet]
        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMessage(Message message)
        {
            message.IsRead = false;
            message.SendDate = DateTime.Now;

            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
