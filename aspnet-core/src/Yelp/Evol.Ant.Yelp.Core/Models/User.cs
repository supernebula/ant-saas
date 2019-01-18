using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class User
    {
        public User()
        {
            Review = new HashSet<Review>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int? ReviewCount { get; set; }
        public DateTime? YelpingSince { get; set; }
        public int? Useful { get; set; }
        public int? Funny { get; set; }
        public int? Cool { get; set; }
        public int? Fans { get; set; }
        public float? AverageStars { get; set; }
        public int? ComplimentHot { get; set; }
        public int? ComplimentMore { get; set; }
        public int? ComplimentProfile { get; set; }
        public int? ComplimentCute { get; set; }
        public int? ComplimentList { get; set; }
        public int? ComplimentNote { get; set; }
        public int? ComplimentPlain { get; set; }
        public int? ComplimentCool { get; set; }
        public int? ComplimentFunny { get; set; }
        public int? ComplimentWriter { get; set; }
        public int? ComplimentPhotos { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}
