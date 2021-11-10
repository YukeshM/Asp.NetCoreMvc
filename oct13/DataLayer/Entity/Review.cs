using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Review
    {
        public Review()
        {
            SkillRatings = new HashSet<SkillRating>();
        }

        public int ReviewId { get; set; }
        public int? CandidateRoundInformationId { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string Comment { get; set; }

        public virtual CandidateRoundInformation CandidateRoundInformation { get; set; }
        public virtual ICollection<SkillRating> SkillRatings { get; set; }
    }
}
