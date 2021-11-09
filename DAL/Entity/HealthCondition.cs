using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Entity
{
    public partial class HealthCondition
    {
        public int Id { get; set; }
        public string AnyIllness { get; set; }
        public string AnySurgery { get; set; }
        public int? CandidateId { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
