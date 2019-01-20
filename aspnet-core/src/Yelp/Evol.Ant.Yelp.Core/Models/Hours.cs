using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Hours
    {
        public string Id { get; set; }
        public string Hours1 { get; set; }
        public string BusinessId { get; set; }

        public virtual Business Business { get; set; }
    }
}
