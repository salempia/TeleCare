using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleCare.Models
{
    public partial class Factory
    {
        public Factory()
        {
            this.Cars = new HashSet<Cars>();
        }
        public int FactoryId { get; set; }
        public virtual ICollection<Cars> Cars { get; set; }
    }
}