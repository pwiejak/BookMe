namespace BookMe.Database.Entities
{
    public class Court : BaseEntity
    {
        public int Number { get; set; }

        public int ClubId { get; set; }

        public virtual Club Club { get; set; }
    }
}