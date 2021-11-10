using BusinessLayer.CustomModel;
using BusinessLayer.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InterviewProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class InterviewManagementController : ControllerBase
    {

        private readonly ICrudBAL _crudBAL;

        public InterviewManagementController(ICrudBAL crudBAL)
        {
            this._crudBAL = crudBAL;
        }


        
        [HttpPost]
        public IActionResult Create(CreateCandidateBAL createCandidate)
        {
            if (ModelState.IsValid)
            {
                _crudBAL.Create(createCandidate);
                return Ok();
            }
            return BadRequest(createCandidate);

        }

        [HttpPost]
        public IActionResult CreateInterviewer(CreateInterviewerForTheCandidateBAL createInterviewerForTheCandidate)
        {
            if (ModelState.IsValid)
            {
                _crudBAL.CreateInterviewer(createInterviewerForTheCandidate);
                return Ok();
            }
            return BadRequest(createInterviewerForTheCandidate);
        }      

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<GetCandidateRoundBAL> getCandidateList = _crudBAL.Get();
            return Ok(getCandidateList);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id != 0)
            {
                var getCandidateDetail = _crudBAL.GetById(id);
                return Ok(getCandidateDetail);
            }
            return BadRequest("No data available");
        }

        [HttpGet]
        public IActionResult GetCandidateStatus()
        {
            IEnumerable<GetCandidateStatusBAL> getCandidateStatuses = _crudBAL.GetCandidateStatus();
            return Ok(getCandidateStatuses);
        }

        [HttpGet]
        public IActionResult GetSource()
        {
            IEnumerable<GetSourceBAL> getSources = _crudBAL.GetSource();
            return Ok(getSources);
        }

        [HttpGet]
        public IActionResult GetRating()
        {
            IEnumerable<GetRatingBAL> getRatings = _crudBAL.GetRating();
            return Ok(getRatings);
        }

        [HttpPut]
        public IActionResult Update(UpdateRoundInfoByCandidateIdBAL updateRoundInfoByCandidateId)
        {
            if (ModelState.IsValid)
            {
                _crudBAL.Update(updateRoundInfoByCandidateId);
                return Ok();
            }
            return BadRequest(updateRoundInfoByCandidateId);
        }
    }
}
