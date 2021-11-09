using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class CandidateStatus
    {
        public CandidateStatus()
        {
            CandidateRoundInformations = new HashSet<CandidateRoundInformation>();
        }

        public int CandidateStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CandidateRoundInformation> CandidateRoundInformations { get; set; }
    }
}
