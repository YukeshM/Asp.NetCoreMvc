using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class CandidateStatus
    {
        public CandidateStatus()
        {
            CandidateRoundInformations = new HashSet<CandidateRoundInformation>();
        }

        public int Id { get; set; }
        public bool IsCleared { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CandidateRoundInformation> CandidateRoundInformations { get; set; }
    }
}
