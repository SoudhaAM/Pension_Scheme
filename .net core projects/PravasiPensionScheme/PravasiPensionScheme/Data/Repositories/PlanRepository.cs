using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PravasiPensionScheme.Entities;
using PravasiPensionScheme.Interfaces;

namespace PravasiPensionScheme.Data.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public PlanRepository(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IEnumerable<Plan>> GetPlans()
        {
            return await _context.Plans.ToListAsync();
        }

        public async Task<IEnumerable<Plan>> PostPlans(Plan plan)
        {
            await _context.Plans.AddAsync(plan);
            _context.SaveChanges();
            return await _context.Plans.ToListAsync();
        }
    }
}
