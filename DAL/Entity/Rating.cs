using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Entity
{
    public partial class Rating
    {
        public Rating()
        {
            SoftSkillAptitudeNavigations = new HashSet<SoftSkill>();
            SoftSkillAttitudeNavigations = new HashSet<SoftSkill>();
            SoftSkillInitiativeNavigations = new HashSet<SoftSkill>();
            SoftSkillLeadershipNavigations = new HashSet<SoftSkill>();
            SoftSkillListeningSkillNavigations = new HashSet<SoftSkill>();
            SoftSkillOtherNavigations = new HashSet<SoftSkill>();
            SoftSkillVerbalNavigations = new HashSet<SoftSkill>();
            SoftSkillWillingnessToLearnNavigations = new HashSet<SoftSkill>();
            SoftSkillWrittenNavigations = new HashSet<SoftSkill>();
            TechnicalSkillAnalyticalSkillNavigations = new HashSet<TechnicalSkill>();
            TechnicalSkillConceptNavigations = new HashSet<TechnicalSkill>();
            TechnicalSkillDomainNavigations = new HashSet<TechnicalSkill>();
            TechnicalSkillFocussedAndAlertNavigations = new HashSet<TechnicalSkill>();
            TechnicalSkillOtherNavigations = new HashSet<TechnicalSkill>();
            TechnicalSkillProblemSolvingNavigations = new HashSet<TechnicalSkill>();
            TechnicalSkillSkillSetNavigations = new HashSet<TechnicalSkill>();
            TechnicalSkillTechnicalNavigations = new HashSet<TechnicalSkill>();
        }

        public int Id { get; set; }
        public string RatingValue { get; set; }

        public virtual ICollection<SoftSkill> SoftSkillAptitudeNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillAttitudeNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillInitiativeNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillLeadershipNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillListeningSkillNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillOtherNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillVerbalNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillWillingnessToLearnNavigations { get; set; }
        public virtual ICollection<SoftSkill> SoftSkillWrittenNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillAnalyticalSkillNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillConceptNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillDomainNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillFocussedAndAlertNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillOtherNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillProblemSolvingNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillSkillSetNavigations { get; set; }
        public virtual ICollection<TechnicalSkill> TechnicalSkillTechnicalNavigations { get; set; }
    }
}
