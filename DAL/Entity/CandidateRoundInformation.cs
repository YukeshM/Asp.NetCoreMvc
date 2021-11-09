using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Entity
{
    public partial class CandidateRoundInformation
    {
        public int Id { get; set; }
        public int? RoundId { get; set; }
        public int? CandidateId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string InterviewerComment { get; set; }
        public int? InterviewerId { get; set; }
        public int? StatusId { get; set; }
        public byte[] Document { get; set; }
        public string Comment { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Interviewer Interviewer { get; set; }
        public virtual RoundInformation Round { get; set; }
        public virtual CandidateStatus Status { get; set; }
    }
}
