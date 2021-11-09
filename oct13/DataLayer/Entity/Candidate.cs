using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateRoundInformations = new HashSet<CandidateRoundInformation>();
            HealthConditions = new HashSet<HealthCondition>();
            Resumes = new HashSet<Resume>();
        }

        public int CandidateId { get; set; }
        public string ReferredBy { get; set; }
        public string Name { get; set; }
        public string LastEmployer { get; set; }
        public string LastDesignation { get; set; }
        public int Experience { get; set; }
        public string NoticePeriod { get; set; }
        public int SourceId { get; set; }

        public virtual Source Source { get; set; }
        public virtual ICollection<CandidateRoundInformation> CandidateRoundInformations { get; set; }
        public virtual ICollection<HealthCondition> HealthConditions { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
