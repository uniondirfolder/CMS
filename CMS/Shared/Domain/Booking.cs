namespace CMS.Shared.Domain
{
    public class Booking: BaseDomainModel
    {
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public DateTime? DateOut { get; set; }
        public DateTime? DateIn { get; set; }


        public override void SetDateCreated()
        {
            this.DateCreated = DateTime.Now;
        }

        public override void SetDateUpdated()
        {
            this.DateUpdated = DateTime.Now;
        }
    }
}