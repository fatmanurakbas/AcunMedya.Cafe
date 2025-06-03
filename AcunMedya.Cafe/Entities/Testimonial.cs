using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcunMedya.Cafe.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public int raiting { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; } // görsel yükleme
    }
}
