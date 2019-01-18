using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Review
    {
        public string Id { get; set; }
        public int? Stars { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
        public int? Useful { get; set; }
        public int? Funny { get; set; }
        public int? Cool { get; set; }
        public string BusinessId { get; set; }
        public string UserId { get; set; }

        public virtual Business Business { get; set; }
        public virtual User User { get; set; }
    }
}
