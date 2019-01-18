using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Photo
    {
        public string Id { get; set; }
        public string BusinessId { get; set; }
        public string Caption { get; set; }
        public string Label { get; set; }

        public virtual Business Business { get; set; }
    }
}
