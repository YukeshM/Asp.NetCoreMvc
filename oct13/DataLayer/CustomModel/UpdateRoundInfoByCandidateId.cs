using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.CustomModel
{
    public class UpdateRoundInfoByCandidateId
    {
        public int CandidateId
        {
            get; set;
        }

        public int RoundId
        {
            get; set;
        }

        public DateTime InterviewDate
        {
            get; set;
        }

        public int InterviewerId
        {
            get; set;
        }

        public int StatusId
        {
            get; set;
        }

    }
}
