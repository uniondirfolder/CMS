using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Shared.Domain
{
    public class Vehicle: BaseDomainModel
    {
        public int Year { get; set; }
        public string? Vin { get; set; }
        public string? LicensePlateNumber { get; set; }

        public double RentalRate { get; set; }

        public virtual List<Booking>? Bookings { get; set; }

        public int ModelId { get; set; }
        public virtual Model? Model { get; set; }

        public int MakelId { get; set; }
        public virtual Make? Make { get; set; }

        public int ColourId { get; set; }
        public virtual Colour? Colour { get; set; }


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
