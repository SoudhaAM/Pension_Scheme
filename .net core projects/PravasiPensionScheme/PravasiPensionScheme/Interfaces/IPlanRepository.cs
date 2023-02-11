using PravasiPensionScheme.Entities;

namespace PravasiPensionScheme.Interfaces
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetPlans();
        Task<IEnumerable<Plan>> PostPlans(Plan plan);

    }
}
