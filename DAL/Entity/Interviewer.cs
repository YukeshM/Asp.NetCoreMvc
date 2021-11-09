using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Entity
{
    public partial class Interviewer
    {
        public Interviewer()
        {
            CandidateRoundInformations = new HashSet<CandidateRoundInformation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] InterviewerSign { get; set; }

        public virtual ICollection<CandidateRoundInformation> CandidateRoundInformations { get; set; }
    }
}
