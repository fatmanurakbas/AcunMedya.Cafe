using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;

namespace AcunMedya.Cafe.Services
{
    public class NotificationService
    {
        private readonly CafeContext _context;

        public NotificationService(CafeContext context)
        {
            _context = context;
        }

        public void Create(string title, string icon = "fa fa-bell", string iconColor = "text-primary")
        {
            var notification = new Notification
            {
                Title = title,
                Time = DateTime.Now,
                Icon = icon,
                Iconcolor = iconColor,
                IsRead = "false"
            };

            _context.Notifications.Add(notification);
            _context.SaveChanges();
        }
    }
}
