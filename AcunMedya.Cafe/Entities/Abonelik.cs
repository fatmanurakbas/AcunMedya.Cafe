using System.ComponentModel.DataAnnotations;
namespace AcunMedya.Cafe.Entities
{
    public class Abonelik
    {
        public int AbonelikId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}
