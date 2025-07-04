using AcunMedya.Cafe.Entities;

using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Cafe.Context
{
    public class CafeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FATMANUR\\SQLEXPRESS; initial catalog=DbAcunMedyaCafe; integrated Security=true; TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Adres> Adress { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Abonelik> Aboneliks { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<NavbarViewModel> NavbarViewModels { get; set; }
        public DbSet<SosyalMedya> SosyalMedyas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // DashboardViewModel bir key'e sahip değil, sadece ViewModel olarak kullanılıyor
            modelBuilder.Entity<DashboardViewModel>().HasNoKey();
        }



    }
}
