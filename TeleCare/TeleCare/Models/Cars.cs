using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleCare.Models
{
    public partial class Cars
    {
        public Cars()
        {
            this.ExtraCarFeatures = new HashSet<ExtraCarFeatures>();
        }

        public int CarId { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string SafetyRating { get; set; }        

        public virtual Cars Factory { get; set; }
        public virtual ICollection<ExtraCarFeatures> ExtraCarFeatures { get; set; }

    }
}