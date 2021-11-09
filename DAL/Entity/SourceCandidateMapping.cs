using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Entity
{
    public partial class SourceCandidateMapping
    {
        public int Id { get; set; }
        public int? SourceId { get; set; }
        public int? CandidateId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Source Source { get; set; }
    }
}
