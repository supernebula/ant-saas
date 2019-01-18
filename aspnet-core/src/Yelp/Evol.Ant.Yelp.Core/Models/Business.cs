using System;
using System.Collections.Generic;

namespace Evol.Ant.Yelp.Models
{
    public partial class Business
    {
        public Business()
        {
            Photo = new HashSet<Photo>();
            Review = new HashSet<Review>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Neighborhood { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public float? Stars { get; set; }
        public int? ReviewCount { get; set; }
        public sbyte? IsOpen { get; set; }

        public virtual ICollection<Photo> Photo { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
