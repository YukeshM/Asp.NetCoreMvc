using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class SkillRating
    {
        public int SkillRatingId { get; set; }
        public int ReviewId { get; set; }
        public int SkillId { get; set; }
        public int RatingId { get; set; }

        public virtual Rating Rating { get; set; }
        public virtual Review Review { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
