using BusinessLayer.CustomModel;
using System.Collections.Generic;

namespace BusinessLayer.Interface
{
    public interface ICrudBAL
    {
        void Create(CreateCandidateBAL createCandidate);

        void CreateInterviewer(CreateInterviewerForTheCandidateBAL createInterviewerForTheCandidate);

        void CreateSoftSkill(CreateSoftskillForCandidateBAL createSoftskillForCandidate);

        void CreateTechnicalSkill(CreateTechnicalSkillForCandidateBAL createTechnicalSkillForCandidate);

        IEnumerable<GetCandidateRoundBAL> Get();

        GetCandidateRoundBAL GetById(int id);


        void Update(UpdateRoundInfoByCandidateIdBAL updateRoundInfoByCandidateId);
    }
}
