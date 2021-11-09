using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Resume
    {
        public int ResumeId { get; set; }
        public byte[] File { get; set; }
        public int CandidateId { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
