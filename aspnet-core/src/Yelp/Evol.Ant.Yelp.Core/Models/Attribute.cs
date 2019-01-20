using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Attribute
    {
        public string Id { get; set; }
        public string BusinessId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual Business Business { get; set; }
    }
}
