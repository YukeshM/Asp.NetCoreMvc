using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Entity
{
    public partial class RoundInformation
    {
        public RoundInformation()
        {
            CandidateRoundInformations = new HashSet<CandidateRoundInformation>();
        }

        public int Id { get; set; }
        public string RoundName { get; set; }

        public virtual ICollection<CandidateRoundInformation> CandidateRoundInformations { get; set; }
    }
}
