using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Checkin
    {
        public string Id { get; set; }
        public string BusinessId { get; set; }
        public string Date { get; set; }
        public int? Count { get; set; }

        public virtual Business Business { get; set; }
    }
}
