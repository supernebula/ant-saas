using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class EliteYears
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Year { get; set; }

        public virtual User User { get; set; }
    }
}
