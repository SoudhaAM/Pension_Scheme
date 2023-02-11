using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PravasiPensionScheme.DTOs;
using PravasiPensionScheme.Entities;
using PravasiPensionScheme.Interfaces;
using System.Collections.Generic;

namespace PravasiPensionScheme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PlansController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        [HttpGet]
        public async Task<IActionResult> Getplans()
        {
            var plansData = await _unitOfWork.planRepository.GetPlans();
            return Ok(_mapper.Map<IEnumerable<PlansDto>> (plansData));
            //return Ok(await dbContext.Contacts.ToListAsync());

        }
        [HttpPost]
        public async Task<IActionResult>AddPlans([FromForm]PlansDto PlanRequest)
        {
            var plan = _mapper.Map<Plan>(PlanRequest);
            IEnumerable<Plan> PlanDetails = await _unitOfWork.planRepository.PostPlans(plan);
            return Ok(_mapper.Map<IEnumerable<PlansDto>>(PlanDetails));
        }
      
    }
}

