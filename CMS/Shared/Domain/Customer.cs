namespace CMS.Shared.Domain
{
    public class Customer:BaseDomainModel
    {
        public string? TaxId { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }

        public virtual List<Booking>? Bookings { get; set; }


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