using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class CandidateRoundInformation
    {
        public CandidateRoundInformation()
        {
            Reviews = new HashSet<Review>();
        }

        public int CandidateRoundInformationId { get; set; }
        public int? RoundId { get; set; }
        public int? CandidateId { get; set; }
        public DateTime InterviewDate { get; set; }
        public int? InterviewerId { get; set; }
        public int? StatusId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Interviewer Interviewer { get; set; }
        public virtual RoundInformation Round { get; set; }
        public virtual CandidateStatus Status { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
