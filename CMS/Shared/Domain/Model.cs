using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Shared.Domain
{
    public class Model: BaseDomainModel
    {
        public string? Name { get; set; }

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
