using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace B2C2AdvChallenge.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Naam")]
        public string Name { get; set; }
        [DisplayName("Beschrijving")]
        public string Description { get; set; }
        [DisplayName("Volgnummer")]
        [Range(0, 10)]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        [DisplayName("Tijd")]
        public string ChallengeTime { get; set; }

    }
}
