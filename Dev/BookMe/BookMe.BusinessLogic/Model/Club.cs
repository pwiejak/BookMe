using System.ComponentModel.DataAnnotations;

namespace BookMe.BusinessLogic.Model
{
    public class Club
    {
        [Required]
        public string Email { get; set; }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}