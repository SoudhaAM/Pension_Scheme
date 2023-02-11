using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PravasiPensionScheme.DTOs;
using PravasiPensionScheme.Entities;
using PravasiPensionScheme.Interfaces;
using PravasiPensionScheme.Migrations;

namespace PravasiPensionScheme.Data.Repositories
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ContactsRepository(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<IEnumerable<Contact>> GetContacts()
        {
           return await _context.Contacts.ToListAsync();
        }


        async Task<IEnumerable<Contact>> IContactsRepository.PostContacts(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            _context.SaveChanges();
            return await _context.Contacts.ToListAsync();
        }
    }
}
