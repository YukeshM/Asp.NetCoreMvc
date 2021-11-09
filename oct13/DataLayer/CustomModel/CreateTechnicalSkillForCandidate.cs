using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.CustomModel
{
    public class CreateTechnicalSkillForCandidate
    {
        public int CandidateRoundInformationId
        {
            get; set;
        }

        public int Concept
        {
            get; set;
        }

        public int Technical
        {
            get; set;
        }

        public int Domain
        {
            get; set;
        }

        public int SkillSet
        {
            get; set;
        }

        public int AnalyticalSkill
        {
            get; set;
        }

        public int ProblemSolving
        {
            get; set;
        }

        public int FocussedAndAlert
        {
            get; set;
        }

        public int Other
        {
            get; set;
        }

    }
}
