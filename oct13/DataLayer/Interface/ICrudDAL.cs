using DataLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface ICrudDAL
    {
        void Create(CreateCandidate createCandidate);

        void CreateInterviewer(CreateInterviewerForTheCandidate createInterviewerForTheCandidate);

        

        IEnumerable<GetCandidateRound> Get();

        GetCandidateRound GetById(int id);

        IEnumerable<GetCandidateStatus> GetCandidateStatus();

        IEnumerable<GetRating> GetRating();

        IEnumerable<GetSource> GetSource();


        void Update(UpdateRoundInfoByCandidateId updateRoundInfoByCandidateId);
    }
}
