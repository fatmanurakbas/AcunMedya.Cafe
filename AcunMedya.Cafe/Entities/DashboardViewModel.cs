using System.ComponentModel.DataAnnotations;

namespace AcunMedya.Cafe.Entities
{
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
