using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcunMedya.Cafe.ViewComponents
{
    public class _DefaultBlogComponentPartial : ViewComponent

    {
        private readonly CafeContext _context;

        public _DefaultBlogComponentPartial(CafeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // Blog kayıtlarını tarihe göre tersten sırala (yeni blog yazıları ilk gözüksün)
            var blogs = _context.Blogs.OrderByDescending(b => b.Time).ToList();

            return View(blogs);
        }
    }
}
