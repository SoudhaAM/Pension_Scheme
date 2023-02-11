namespace PravasiPensionScheme.Entities
{
    public class AddContactRequest
    {
        public string Email { get; set; }
        public long phone { get; set; }
        public string? Address { get; set; }
    }
}
