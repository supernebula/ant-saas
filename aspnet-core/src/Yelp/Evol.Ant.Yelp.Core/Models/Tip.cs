using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Tip
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string BusinessId { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
        public int? Likes { get; set; }

        public virtual Business Business { get; set; }
        public virtual User User { get; set; }
    }
}
