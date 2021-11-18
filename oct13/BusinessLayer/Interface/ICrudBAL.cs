using BusinessLayer.CustomModel;
using System.Collections.Generic;

namespace BusinessLayer.Interface
{
    public interface ICrudBAL
    {
        void Create(CreateCandidateBAL createCandidate);

        void CreateInterviewer(CreateInterviewerForTheCandidateBAL createInterviewerForTheCandidate);

        

        IEnumerable<GetCandidateRoundBAL> Get();

        GetCandidateRoundBAL GetById(int id);

        IEnumerable<GetCandidateStatusBAL> GetCandidateStatus();

        IEnumerable<GetRatingBAL> GetRating();

        IEnumerable<GetSourceBAL> GetSource();

        IEnumerable<GetSkillBAL> GetSkill();
        IEnumerable<GetRoundBAL> GetRound();

        IEnumerable<GetInterviewerBAL> GetInterviewer();

        void UpdateCanidateRoundInformation(UpdateCandidateRoundInformationBAL updateCandidateRoundInformation);

        void Update(UpdateRoundInfoByCandidateIdBAL updateRoundInfoByCandidateId);
    }
}
