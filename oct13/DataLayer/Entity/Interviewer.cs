﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Interviewer
    {
        public Interviewer()
        {
            CandidateRoundInformations = new HashSet<CandidateRoundInformation>();
        }

        public int InterviewerId { get; set; }
        public string Name { get; set; }
        public bool InterviewerSign { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string InterviewerComment { get; set; }

        public virtual ICollection<CandidateRoundInformation> CandidateRoundInformations { get; set; }
    }
}
