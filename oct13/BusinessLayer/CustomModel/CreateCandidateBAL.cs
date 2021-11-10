using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CustomModel
{
    public class CreateCandidateBAL
    {

        public string ReferredBy
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string LastEmployer
        {
            get; set;
        }

        public string LastDesignation
        {
            get; set;
        }

        public int Experience
        {
            get; set;
        }

        public string NoticePeriod
        {
            get; set;
        }

        public int SourceId
        {
            get; set;
        }

        public string MedicalStatus
        {
            get; set;
        }

    }
}
