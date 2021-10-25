using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class TechnicalSkill
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? Concept { get; set; }
        public int? Technical { get; set; }
        public int? Domain { get; set; }
        public int? SkillSet { get; set; }
        public int? AnalyticalSkill { get; set; }
        public int? ProblemSolving { get; set; }
        public int? FocussedAndAlert { get; set; }
        public int? Other { get; set; }
        public int OverallRating { get; set; }

        public virtual Rating AnalyticalSkillNavigation { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Rating ConceptNavigation { get; set; }
        public virtual Rating DomainNavigation { get; set; }
        public virtual Rating FocussedAndAlertNavigation { get; set; }
        public virtual Rating OtherNavigation { get; set; }
        public virtual Rating ProblemSolvingNavigation { get; set; }
        public virtual Rating SkillSetNavigation { get; set; }
        public virtual Rating TechnicalNavigation { get; set; }
    }
}
