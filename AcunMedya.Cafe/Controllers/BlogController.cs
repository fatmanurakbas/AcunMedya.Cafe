using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Cafe.Controllers
{
    public class BlogController : Controller
    {
        private readonly CafeContext _context;

        public BlogController(CafeContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //Eager Loading
            var values = _context.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog model)
        {

            if (model.ImageFile != null)
            {
                //uygulamanın çalıştığı dizini al
                var currenDirectory = Directory.GetCurrentDirectory();

                //uygulamanın uzantısını al (jpg,png)
                var extension = Path.GetExtension(model.ImageFile.FileName);

                //benzersiz bir dosya adı oluştur
                var filename = Guid.NewGuid().ToString();

                //Kayıt edilecek Dosyanın yolu
                var saveLocation = Path.Combine(currenDirectory, "wwwroot/images", filename + extension);

                //belirtilen konumda bir dosya oluştur
                var stream = new FileStream(saveLocation, FileMode.Create);

                //dosyayaı fiziksel olarak sunucuya yazar
                model.ImageFile.CopyTo(stream);

                model.ImageUrl = "/images/" + filename + extension;
            }

            _context.Blogs.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {


            var value = _context.Blogs.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog model)
        {
            if (model.ImageFile != null)
            {
                //uygulamanın çalıştığı dizini al
                var currenDirectory = Directory.GetCurrentDirectory();

                //uygulamanın uzantısını al (jpg,png)
                var extension = Path.GetExtension(model.ImageFile.FileName);

                //benzersiz bir dosya adı oluştur
                var filename = Guid.NewGuid().ToString();

                //Kayıt edilecek Dosyanın yolu
                var saveLocation = Path.Combine(currenDirectory, "wwwroot/images", filename + extension);

                //belirtilen konumda bir dosya oluştur
                var stream = new FileStream(saveLocation, FileMode.Create);

                //dosyayaı fiziksel olarak sunucuya yazar
                model.ImageFile.CopyTo(stream);

                model.ImageUrl = "/images/" + filename + extension;
            }

            _context.Blogs.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBlog(int id)
        {
            var value = _context.Blogs.Find(id);
            _context.Blogs.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
