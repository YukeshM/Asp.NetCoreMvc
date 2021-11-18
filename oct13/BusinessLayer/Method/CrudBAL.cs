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
                    SourceId = createCandidate.SourceId,
                    MedicalStatus = createCandidate.MedicalStatus
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

        public IEnumerable<GetCandidateRoundBAL> Get()
        {
            try
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
                        InterviewerId = candidateList[i].InterviewerId,
                        InterviewerName = candidateList[i].InterviewerName,
                        LastDesignation = candidateList[i].LastDesignation,
                        LastEmployer = candidateList[i].LastEmployer,
                        NoticePeriod = candidateList[i].NoticePeriod,
                        ReferredBy = candidateList[i].ReferredBy,
                        RoundInformationId = candidateList[i].RoundInformationId,
                        RoundName = candidateList[i].RoundName,
                        CandidateStatusId = candidateList[i].CandidateStatusId,
                        SourceId = candidateList[i].SourceId,
                        SourceName = candidateList[i].SourceName,
                        MedicalStatus = candidateList[i].MedicalStatus
                    };
                    list.Add(getCandidateRoundBAL);
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public GetCandidateRoundBAL GetById(int id)
        {
            try
            {
                var candidateRoundInfo = _crudDAL.GetById(id);
                var candidateRoundDetail = new GetCandidateRoundBAL()
                {
                    CandidateId = candidateRoundInfo.CandidateId,
                    CandidateName = candidateRoundInfo.CandidateName,
                    ReferredBy = candidateRoundInfo.ReferredBy,
                    RoundInformationId = candidateRoundInfo.RoundInformationId,
                    RoundName = candidateRoundInfo.RoundName,
                    LastEmployer = candidateRoundInfo.LastEmployer,
                    LastDesignation = candidateRoundInfo.LastDesignation,
                    Experience = candidateRoundInfo.Experience,
                    InterviewDate = candidateRoundInfo.InterviewDate,
                    InterviewerId = candidateRoundInfo.InterviewerId,
                    InterviewerName = candidateRoundInfo.InterviewerName,
                    NoticePeriod = candidateRoundInfo.NoticePeriod,
                    CandidateStatusId = candidateRoundInfo.CandidateStatusId,
                    CandidateStatus = candidateRoundInfo.CandidateStatus,
                    SourceId = candidateRoundInfo.SourceId,
                    SourceName = candidateRoundInfo.SourceName
                };
                return candidateRoundDetail;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<GetCandidateStatusBAL> GetCandidateStatus()
        {
            try
            {
                var detailsFromDb = _crudDAL.GetCandidateStatus().ToList();
                var detailsForBAL = new List<GetCandidateStatusBAL>();
                for (int i = 0; i < detailsFromDb.Count; i++)
                {
                    var details = new GetCandidateStatusBAL()
                    {
                        CandidateStatusId = detailsFromDb[i].CandidateStatusId,
                        Status = detailsFromDb[i].Status
                    };

                    detailsForBAL.Add(details);
                }

                return detailsForBAL;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<GetInterviewerBAL> GetInterviewer()
        {
            try
            {
                var detailsFromDB = _crudDAL.GetInterviewer().ToList();
                var detailsForBAL = new List<GetInterviewerBAL>();

                for (int i = 0; i < detailsFromDB.Count; i++)
                {
                    var details = new GetInterviewerBAL()
                    {
                        InterviewerId = detailsFromDB[i].InterviewerId,
                        Name = detailsFromDB[i].Name,
                        InterviewerSign = detailsFromDB[i].InterviewerSign
                    };
                    detailsForBAL.Add(details);
                }

                return detailsForBAL;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<GetRatingBAL> GetRating()
        {
            try
            {
                var detailsFromDb = _crudDAL.GetRating().ToList();
                var detailsForBAL = new List<GetRatingBAL>();

                for (int i = 0; i < detailsFromDb.Count; i++)
                {
                    var details = new GetRatingBAL()
                    {
                        RatingId = detailsFromDb[i].RatingId,
                        RatingValue = detailsFromDb[i].RatingValue
                    };
                    detailsForBAL.Add(details);
                }

                return detailsForBAL;
            }
            catch (Exception)
            {

                throw;
            };
        }

        public IEnumerable<GetRoundBAL> GetRound()
        {
            try
            {
                var detailsFromDB = _crudDAL.GetRound().ToList();
                var detailsForBAL = new List<GetRoundBAL>();

                for (int i = 0; i < detailsFromDB.Count; i++)
                {
                    var details = new GetRoundBAL()
                    {
                        RoundInformationId = detailsFromDB[i].RoundInformationId,
                        RoundName = detailsFromDB[i].RoundName
                    };
                    detailsForBAL.Add(details);
                }
                return detailsForBAL;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<GetSkillBAL> GetSkill()
        {
            try
            {
                var detailsFromDB = _crudDAL.GetSkill().ToList();
                var detailsForBAL = new List<GetSkillBAL>();

                for (int i = 0; i < detailsFromDB.Count; i++)
                {
                    var details = new GetSkillBAL()
                    {
                        SkillId = detailsFromDB[i].SkillId,
                        SkillName = detailsFromDB[i].SkillName
                    };

                    detailsForBAL.Add(details);
                }

                return detailsForBAL;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<GetSourceBAL> GetSource()
        {
            try
            {
                var detailsFromDb = _crudDAL.GetSource().ToList();
                var detailsForBAL = new List<GetSourceBAL>();

                for (int i = 0; i < detailsFromDb.Count; i++)
                {
                    var details = new GetSourceBAL()
                    {
                        SourceId = detailsFromDb[i].SourceId,
                        SourceName = detailsFromDb[i].SourceName
                    };

                    detailsForBAL.Add(details);
                }

                return detailsForBAL;
            }
            catch (Exception)
            {

                throw;
            }
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

        public void UpdateCanidateRoundInformation(UpdateCandidateRoundInformationBAL updateCandidateRoundInformation)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
