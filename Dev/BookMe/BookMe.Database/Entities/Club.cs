using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMe.Database.Entities
{
    public class Club : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public byte[] Image { get; set; }

        public virtual ICollection<Court> Courts { get; set; }
    }
}