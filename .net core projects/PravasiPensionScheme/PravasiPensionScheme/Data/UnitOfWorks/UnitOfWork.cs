using AutoMapper;
using PravasiPensionScheme.Data.Repositories;
using PravasiPensionScheme.Interfaces;

namespace PravasiPensionScheme.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UnitOfWork(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

     
        public IContactsRepository ContactRepository =>  new ContactsRepository(_context, _mapper);

        public IPlanRepository planRepository => new PlanRepository(_context, _mapper);
    }
}
