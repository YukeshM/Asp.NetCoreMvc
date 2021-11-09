using BusinessLayer.CustomModel;
using BusinessLayer.Interface;
using DataLayer.CustomModel;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Method
{
    public class CrudBAL : ICrudBAL
    {
        private readonly ICrudDAL _crudDAL;
        public CrudBAL(ICrudDAL crudDAL)
        {
            this._crudDAL = crudDAL;
        }
        public void Create(CreateCandidateBAL createCandidate)
        {
            try
            {
                var model = new CreateCandidate()
                {
                    ReferredBy = createCandidate.ReferredBy,
                    Name = createCandidate.Name,
                    LastEmployer = createCandidate.LastEmployer,
                    LastDesignation = createCandidate.LastDesignation,
                    Experience = createCandidate.Experience,
                    NoticePeriod = createCandidate.NoticePeriod,
                    SourceId = createCandidate.SourceId
                };
                _crudDAL.Create(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CreateInterviewer(CreateInterviewerForTheCandidateBAL createInterviewerForTheCandidate)
        {
            try
            {
                var model = new CreateInterviewerForTheCandidate()
                {
                    CandidateId = createInterviewerForTheCandidate.CandidateId,
                    RoundId = createInterviewerForTheCandidate.RoundId,
                    InterviewDate = createInterviewerForTheCandidate.InterviewDate,
                    InterviewerId = createInterviewerForTheCandidate.InterviewerId,
                    StatusId = createInterviewerForTheCandidate.StatusId
                };
                _crudDAL.CreateInterviewer(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CreateSoftSkill(CreateSoftskillForCandidateBAL createSoftskillForCandidate)
        {
            try
            {
                var model = new CreateSoftskillForCandidate()
                {
                    CandidateRoundInformationId = createSoftskillForCandidate.CandidateRoundInformationId,
                    Aptitude = createSoftskillForCandidate.Aptitude,
                    Attitude = createSoftskillForCandidate.Attitude,
                    Initiative = createSoftskillForCandidate.Initiative,
                    Leadership = createSoftskillForCandidate.Leadership,
                    ListeningSkill = createSoftskillForCandidate.ListeningSkill,
                    Verbal = createSoftskillForCandidate.Verbal,
                    WillingnessToLearn = createSoftskillForCandidate.WillingnessToLearn,
                    Written = createSoftskillForCandidate.Written,
                    Other = createSoftskillForCandidate.Other
                };
                _crudDAL.CreateSoftSkill(model);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CreateTechnicalSkill(CreateTechnicalSkillForCandidateBAL createTechnicalSkillForCandidate)
        {
            try
            {
                var model = new CreateTechnicalSkillForCandidate()
                {
                    CandidateRoundInformationId = createTechnicalSkillForCandidate.CandidateRoundInformationId,
                    AnalyticalSkill = createTechnicalSkillForCandidate.AnalyticalSkill,
                    Concept = createTechnicalSkillForCandidate.Concept,
                    Domain = createTechnicalSkillForCandidate.Domain,
                    FocussedAndAlert = createTechnicalSkillForCandidate.FocussedAndAlert,
                    Other = createTechnicalSkillForCandidate.Other,
                    ProblemSolving = createTechnicalSkillForCandidate.ProblemSolving,
                    SkillSet = createTechnicalSkillForCandidate.SkillSet,
                    Technical = createTechnicalSkillForCandidate.Technical
                };
                _crudDAL.CreateTechnicalSkill(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<GetCandidateRoundBAL> Get()
        {
            var candidateList = _crudDAL.Get().ToList();
            var list = new List<GetCandidateRoundBAL>();
            for (int i = 0; i < candidateList.Count; i++)
            {
                GetCandidateRoundBAL getCandidateRoundBAL = new GetCandidateRoundBAL()
                {
                    CandidateId = candidateList[i].CandidateId,
                    CandidateName = candidateList[i].CandidateName,
                    CandidateStatus = candidateList[i].CandidateStatus,
                    Experience = candidateList[i].Experience,
                    InterviewDate = candidateList[i].InterviewDate,
                    InterviewerName = candidateList[i].InterviewerName,
                    LastDesignation = candidateList[i].LastDesignation,
                    LastEmployer = candidateList[i].LastEmployer,
                    NoticePeriod = candidateList[i].NoticePeriod,
                    ReferredBy = candidateList[i].ReferredBy,
                    RoundName = candidateList[i].RoundName,
                    SourceName = candidateList[i].SourceName
                };
                list.Add(getCandidateRoundBAL);
            }
            return list;
        }

        public GetCandidateRoundBAL GetById(int id)
        {
            var candidateRoundInfo = _crudDAL.GetById(id);
            var candidateRoundDetail = new GetCandidateRoundBAL()
            {
                CandidateId = candidateRoundInfo.CandidateId,
                CandidateName = candidateRoundInfo.CandidateName,
                ReferredBy = candidateRoundInfo.ReferredBy,
                RoundName = candidateRoundInfo.RoundName,
                LastEmployer = candidateRoundInfo.LastEmployer,
                LastDesignation = candidateRoundInfo.LastDesignation,
                Experience = candidateRoundInfo.Experience,
                InterviewDate = candidateRoundInfo.InterviewDate,
                InterviewerName = candidateRoundInfo.InterviewerName,
                NoticePeriod = candidateRoundInfo.NoticePeriod,
                CandidateStatus = candidateRoundInfo.CandidateStatus,
                SourceName = candidateRoundInfo.SourceName
            };
            return candidateRoundDetail;
        }

        public void Update(UpdateRoundInfoByCandidateIdBAL updateRoundInfoByCandidateId)
        {
            var updatedCandidateInfo = new UpdateRoundInfoByCandidateId()
            {
                CandidateId = updateRoundInfoByCandidateId.CandidateId,
                InterviewDate = updateRoundInfoByCandidateId.InterviewDate,
                InterviewerId = updateRoundInfoByCandidateId.InterviewerId,
                RoundId = updateRoundInfoByCandidateId.RoundId,
                StatusId = updateRoundInfoByCandidateId.StatusId
            };
            _crudDAL.Update(updatedCandidateInfo);
        }
    }
}
