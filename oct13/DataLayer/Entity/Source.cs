using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Source
    {
        public Source()
        {
            Candidates = new HashSet<Candidate>();
        }

        public int SourceId { get; set; }
        public string SourceName { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}
