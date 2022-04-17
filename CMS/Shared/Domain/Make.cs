using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    

        public override void SetDateCreated()
        {
            DateCreated = DateTime.Now;
        }

        public override void SetDateUpdated()
        {
            DateUpdated = DateTime.Now;
        }
    }
}
