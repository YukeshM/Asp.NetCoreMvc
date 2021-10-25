using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class SoftSkill
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? Written { get; set; }
        public int? Verbal { get; set; }
        public int? Aptitude { get; set; }
        public int? Leadership { get; set; }
        public int? Initiative { get; set; }
        public int? WillingnessToLearn { get; set; }
        public int? Attitude { get; set; }
        public int? ListeningSkill { get; set; }
        public int? Other { get; set; }
        public int OverallRating { get; set; }

        public virtual Rating AptitudeNavigation { get; set; }
        public virtual Rating AttitudeNavigation { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Rating InitiativeNavigation { get; set; }
        public virtual Rating LeadershipNavigation { get; set; }
        public virtual Rating ListeningSkillNavigation { get; set; }
        public virtual Rating OtherNavigation { get; set; }
        public virtual Rating VerbalNavigation { get; set; }
        public virtual Rating WillingnessToLearnNavigation { get; set; }
        public virtual Rating WrittenNavigation { get; set; }
    }
}
