using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Rating
    {
        public Rating()
        {
            SkillRatings = new HashSet<SkillRating>();
        }

        public int RatingId { get; set; }
        public string RatingValue { get; set; }

        public virtual ICollection<SkillRating> SkillRatings { get; set; }
    }
}
