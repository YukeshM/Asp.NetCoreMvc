using System;

namespace BusinessLayer.CustomModel
{
    public class GetCandidateRoundBAL
    {
        public int CandidateId
        {
            get; set;
        }
        public string ReferredBy
        {
            get; set;
        }

        public string CandidateName
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

        public string SourceName
        {
            get; set;
        }

        public string MedicalStatus
        {
            get; set;
        }
        public string RoundName
        {
            get; set;
        }

        public DateTime InterviewDate
        {
            get; set;
        }

        public string InterviewerName
        {
            get; set;
        }

        public string CandidateStatus
        {
            get; set;
        }

    }
}
