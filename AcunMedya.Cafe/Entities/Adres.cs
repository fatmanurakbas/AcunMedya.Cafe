using System.ComponentModel.DataAnnotations;

namespace AcunMedya.Cafe.Entities
{
    public class Adres
    {
        public int AdresId { get; set; }
        public string Location { get; set; }
        public string OpenHours { get; set; }
        public string Email { get; set; }
        public string Call { get; set; }
    }
}
