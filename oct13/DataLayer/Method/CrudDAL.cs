using Dapper;
using DataLayer.CustomModel;
using DataLayer.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataLayer.Method
{
    public class CrudDAL : ICrudDAL
    {
        private readonly string _connectionString;
        public CrudDAL(string connectionString)
        {
            this._connectionString = connectionString;
        }


        public void Create(CreateCandidate createCandidate)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute("spCreateCandidate",
                        new
                        {
                            @ReferredBy = createCandidate.ReferredBy ,
                            @Name = createCandidate.Name,
                            @LastEmployer = createCandidate.LastEmployer,
                            @LastDesignation = createCandidate.LastDesignation,
                            @Experience = createCandidate.Experience,
                            @NoticePeriod = createCandidate.NoticePeriod,
                            @SourceId = createCandidate.SourceId
                        }, commandType: CommandType.StoredProcedure);
                }

            }
            catch(Exception)
            {
                throw;
            }
        }

        public void CreateInterviewer(CreateInterviewerForTheCandidate createInterviewerForTheCandidate)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute("spCreateInterviewerForTheCandidate",
                        new
                        {
                            @RoundId = createInterviewerForTheCandidate.RoundId,
                            @CandidateId = createInterviewerForTheCandidate.CandidateId,
                            @InterviewDate = createInterviewerForTheCandidate.InterviewDate,
                            @InterviewerId = createInterviewerForTheCandidate.InterviewerId,
                            @StatusId = createInterviewerForTheCandidate.StatusId
                        }, commandType: CommandType.StoredProcedure
                        );
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CreateSoftSkill(CreateSoftskillForCandidate createSoftskillForCandidate)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute("spSoftSkillForCandidate",
                        new
                        {
                            @CandidateRoundInformationId = createSoftskillForCandidate.CandidateRoundInformationId,
                            @Written = createSoftskillForCandidate.Written,
                            @Verbal = createSoftskillForCandidate.Verbal,
                            @Aptitude = createSoftskillForCandidate.Aptitude,
                            @Leadership = createSoftskillForCandidate.Leadership,
                            @Initiative = createSoftskillForCandidate.Initiative,
                            @WillingnessToLearn = createSoftskillForCandidate.WillingnessToLearn,
                            @Attitude = createSoftskillForCandidate.Attitude,
                            @ListeningSkill = createSoftskillForCandidate.ListeningSkill,
                            @Other = createSoftskillForCandidate.Other
                        },commandType: CommandType.StoredProcedure

                        );
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CreateTechnicalSkill(CreateTechnicalSkillForCandidate createTechnicalSkillForCandidate)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute("spTechnicalSkillForCandidate",
                        new
                        {
                            @CandidateRoundInformationId = createTechnicalSkillForCandidate.CandidateRoundInformationId,
                            @Concept = createTechnicalSkillForCandidate.Concept,
                            @Technical = createTechnicalSkillForCandidate.Technical,
                            @Domain = createTechnicalSkillForCandidate.Domain,
                            @SkillSet = createTechnicalSkillForCandidate.SkillSet,
                            @AnalyticalSkill = createTechnicalSkillForCandidate.AnalyticalSkill,
                            @ProblemSolving = createTechnicalSkillForCandidate.ProblemSolving,
                            @FocussedAndAlert = createTechnicalSkillForCandidate.FocussedAndAlert,
                            @Other = createTechnicalSkillForCandidate.Other
                        }, commandType: CommandType.StoredProcedure
                        );
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<GetCandidateRound> Get()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    IEnumerable<GetCandidateRound> candidateList = sqlConnection.Query<GetCandidateRound>("spGetCandidateRound", commandType: CommandType.StoredProcedure).ToList();
                    return candidateList;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GetCandidateRound GetById(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {

                sqlConnection.Open();
                var candidateList = new GetCandidateRound();
                candidateList = sqlConnection.Query<GetCandidateRound>("spGetCandidateRoundWithId",
                    new
                    {
                        @Id = id
                    }, commandType: CommandType.StoredProcedure
                    ).FirstOrDefault();            
               
                return candidateList;
            }
            
        }

        public void Update(UpdateRoundInfoByCandidateId updateRoundInfoByCandidateId)
        {
            

            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute("spUpdateRoundInfoByCandidateId",
                        new
                        {
                            @CandidateId = updateRoundInfoByCandidateId.CandidateId,
                            @RoundId = updateRoundInfoByCandidateId.RoundId,
                            @InterviewDate = updateRoundInfoByCandidateId.InterviewDate,
                            @InterviewerId = updateRoundInfoByCandidateId.InterviewerId,
                            @StatusId = updateRoundInfoByCandidateId.StatusId
                        },
                        commandType: CommandType.StoredProcedure
                        );
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
