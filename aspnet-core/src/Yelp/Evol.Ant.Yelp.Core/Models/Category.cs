using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Category
    {
        public string Id { get; set; }
        public string BusinessId { get; set; }
        public string Category1 { get; set; }

        public virtual Business Business { get; set; }
    }
}
