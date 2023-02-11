using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PravasiPensionScheme.Data;
using PravasiPensionScheme.DTOs;
using PravasiPensionScheme.Entities;
using PravasiPensionScheme.Interfaces;
using System.Data.Entity;

namespace PravasiPensionScheme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        //private readonly ApplicationDbContext dbContext;

        //public  ContactsController(ApplicationDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ContactsController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            var contactsData = await _unitOfWork.ContactRepository.GetContacts();
            return Ok(_mapper.Map<IEnumerable<ContactDto>>(contactsData));

        }
        [HttpPost]
        public async Task<IActionResult> AddContact(ContactDto addContactRequest)
        {
            //var Contact = new Contact()
            //{
            //    id = Guid.NewGuid(),
            //    Email = addContactRequest.Email,
            //    Address = addContactRequest.Address,
            //    phone = addContactRequest.phone
            //};
            var contact = _mapper.Map<Contact>(addContactRequest);
            IEnumerable<Contact> contactsData = await _unitOfWork.ContactRepository.PostContacts(contact);
            return Ok(_mapper.Map<IEnumerable<ContactDto>>(contactsData));
            //await dbContext.Contacts.AddAsync(Contact);
            //await dbContext.SaveChangesAsync();
            //return Ok(Contact);
        }
    }
}
