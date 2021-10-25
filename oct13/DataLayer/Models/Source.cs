using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class Source
    {
        public Source()
        {
            SourceCandidateMappings = new HashSet<SourceCandidateMapping>();
        }

        public int Id { get; set; }
        public string SourceName { get; set; }

        public virtual ICollection<SourceCandidateMapping> SourceCandidateMappings { get; set; }
    }
}
