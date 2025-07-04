using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Cafe.Controllers
{
    public class DashboardController : Controller
    {
        private readonly CafeContext _context;

        public DashboardController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // ✅ En Çok Tercih Edilen Kategori
            var mostPreferredCategory = _context.Products
                .GroupBy(p => p.CategoryId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            string categoryName = "Kategori Yok";
            if (mostPreferredCategory != 0)
            {
                var category = _context.Categories
                    .FirstOrDefault(c => c.CategoryId == mostPreferredCategory);

                if (category != null)
                {
                    categoryName = category.CategoryName ?? "Kategori Yok";
                }
            }

            // ✅ En Fazla Mesaj Atılan Gün
            var mostMessagedDay = _context.Messages
                .GroupBy(m => m.SendDate.Date)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            // ✅ En Fazla Blog Yazılan Gün
            var mostBloggedDay = _context.Blogs
                .GroupBy(b => b.Time.Date)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            // ✅ ViewModel'e verileri gönderelim
            var model = new DashboardViewModel
            {
                MostPreferredCategory = categoryName,
                MostMessagedDay = mostMessagedDay,
                MostBloggedDay = mostBloggedDay,
                TotalProducts = _context.Products.Count(),
                TotalCategories = _context.Categories.Count(),
                TotalMessages = _context.Messages.Count(),
                TotalBlogs = _context.Blogs.Count(),
                UnreadMessages = _context.Messages.Count(m => !m.IsRead)
            };

            return View(model);
        }
    }

    // ✅ ViewModel: Dashboard verilerini View'a taşır
    public class DashboardViewModel
    {
        public string MostPreferredCategory { get; set; }
        public DateTime? MostMessagedDay { get; set; }
        public DateTime? MostBloggedDay { get; set; }

        public int TotalProducts { get; set; }
        public int TotalCategories { get; set; }
        public int TotalMessages { get; set; }
        public int TotalBlogs { get; set; }
        public int UnreadMessages { get; set; }
    }
}
