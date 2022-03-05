using Logistics.Shipping.Abstractions.Shipment.Models;

namespace Logistics.Shipping.Abstractions
{
    public interface IShipmentProvider: INamedInstance
    {
        Task<Shipment.Models.Shipment> AddShipment(UpsertShipment request);

        Task<Shipment.Models.Shipment> UpdateShipment(UpsertShipment request);

        Task<bool> DeleteShipment(DeleteShipment request);

        Task CloseShipment(CloseShipments request);
    }
}
