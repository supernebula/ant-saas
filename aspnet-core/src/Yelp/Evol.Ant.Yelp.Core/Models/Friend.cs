using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Friend
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string FriendId { get; set; }

        public virtual User User { get; set; }
    }
}
