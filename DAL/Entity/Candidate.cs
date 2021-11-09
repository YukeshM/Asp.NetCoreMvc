using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Entity
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateRoundInformations = new HashSet<CandidateRoundInformation>();
            HealthConditions = new HashSet<HealthCondition>();
            SoftSkills = new HashSet<SoftSkill>();
            SourceCandidateMappings = new HashSet<SourceCandidateMapping>();
            TechnicalSkills = new HashSet<TechnicalSkill>();
        }

        public int Id { get; set; }
        public string ReferredBy { get; set; }
        public string Name { get; set; }
        public string LastEmployer { get; set; }
        public string LastDesignation { get; set; }
        public int Experience { get; set; }
        public string NoticePeriod { get; set; }
        public string Others { get; set; }

        public virtual ICollection<CandidateRoundInformation> CandidateRoundInformations { get; set; }
        public virtual ICollection<HealthCondition> HealthConditions { get; set; }
        public virtual ICollection<SoftSkill> SoftSkills { get; set; }
        public virtual ICollection<SourceCandidateMapping> SourceCandidateMappings { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkills { get; set; }
    }
}
