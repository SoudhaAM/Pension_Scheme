namespace PravasiPensionScheme.Interfaces
{
    public interface IUnitOfWork
    {
        IContactsRepository ContactRepository { get; }
        IPlanRepository planRepository { get; }
    }
}
