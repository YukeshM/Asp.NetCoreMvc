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



        void Update(UpdateRoundInfoByCandidateIdBAL updateRoundInfoByCandidateId);
    }
}
