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
    [EnableCors("MyCorsImplementationPolicy")]

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

        [HttpPost]
        public IActionResult CreateSoftSkill(CreateSoftskillForCandidateBAL createSoftskillForCandidate)
        {
            if (ModelState.IsValid)
            {
                _crudBAL.CreateSoftSkill(createSoftskillForCandidate);
                return Ok();
            }
            return BadRequest(createSoftskillForCandidate);
        }

        [HttpPost]
        public IActionResult CreateTechnicalSkill(CreateTechnicalSkillForCandidateBAL createTechnicalSkillForCandidate)
        {
            if (ModelState.IsValid)
            {
                _crudBAL.CreateTechnicalSkill(createTechnicalSkillForCandidate);
                return Ok();
            }
            return BadRequest(createTechnicalSkillForCandidate);
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
