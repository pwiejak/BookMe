using System;
using System.ComponentModel.DataAnnotations;

namespace BookMe.Database.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}