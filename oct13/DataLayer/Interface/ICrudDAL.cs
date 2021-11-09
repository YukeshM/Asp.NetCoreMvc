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

        void CreateSoftSkill(CreateSoftskillForCandidate createSoftskillForCandidate);

        void CreateTechnicalSkill(CreateTechnicalSkillForCandidate createTechnicalSkillForCandidate);

        IEnumerable<GetCandidateRound> Get();

        GetCandidateRound GetById(int id);


        void Update(UpdateRoundInfoByCandidateId updateRoundInfoByCandidateId);
    }
}
