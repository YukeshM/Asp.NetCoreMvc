using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class HealthCondition
    {
        public int HealthConditionId { get; set; }
        public bool AnyIllness { get; set; }
        public bool AnySurgery { get; set; }
        public int? CandidateId { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
