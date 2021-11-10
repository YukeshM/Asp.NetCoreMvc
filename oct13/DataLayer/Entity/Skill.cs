using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Skill
    {
        public Skill()
        {
            InverseParent = new HashSet<Skill>();
            SkillRatings = new HashSet<SkillRating>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int? ParentId { get; set; }

        public virtual Skill Parent { get; set; }
        public virtual ICollection<Skill> InverseParent { get; set; }
        public virtual ICollection<SkillRating> SkillRatings { get; set; }
    }
}
