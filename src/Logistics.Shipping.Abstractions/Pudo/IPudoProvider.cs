using Logistics.Shipping.Abstractions.Pudo.Models;

namespace Logistics.Shipping.Abstractions.Pudo
{
    public interface IPudoProvider: INamedInstance
    {
        string Name { get; set; }
        Task<PudoLocation[]> GetLocations(PudoLocationSearch search);
    }
}