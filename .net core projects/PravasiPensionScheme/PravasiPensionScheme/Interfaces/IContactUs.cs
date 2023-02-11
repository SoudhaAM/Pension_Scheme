using PravasiPensionScheme.DTOs;
using PravasiPensionScheme.Entities;

namespace PravasiPensionScheme.Interfaces
{
    public interface IContactsRepository
    {
        Task<IEnumerable<Contact>> GetContacts();
        Task<IEnumerable<Contact>> PostContacts(Contact contact);
       
    }
}
