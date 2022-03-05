using System.Collections.Generic;

namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.Shipment
    /// </summary>
    public class UpsertShipment
    {
        /// <summary>
        /// The code of the carrier to be used for the shipment,
        /// to be specified in either the Centiro format or source system format.
        /// </summary>
        public string Carrier { get; set; }

        /// <summary>
        /// The code of the carrier service to be used for the shipment,
        /// to be specified in either the Centiro format or source system format.
        /// </summary>
        public string CarrierService { get; set; }

        /// <summary>
        /// If carrier supports it, these instructions will be communicated to them
        /// concerning the delivery location of the shipment in for example labels and EDI
        /// </summary>
        public string InstructionDelivery { get; set; }

        /// <summary>
        /// If carrier supports it, these instructions will be communicated to them
        /// concerning the delivery location of the shipment in for example labels and EDI
        /// </summary>
        public string InstructionDelivery2 { get; set; }

        /// <summary>
        /// If carrier supports it, these instructions will be communicated to them
        /// concerning the delivery location of the shipment in for example labels and EDI
        /// </summary>
        public string InstructionDelivery3 { get; set; }

        /// <summary>
        /// If carrier supports it, these instructions will be communicated to them
        /// concerning the pickup location of the shipment in for example labels and EDI
        /// </summary>
        public string InstructionPickup { get; set; }

        /// <summary>
        /// A loading metre corresponds to one linear meter of loading space in a truck.
        /// This is used as a calculation unit for goods that cannot be stacked
        /// or when stacking of or on top of these goods is not allowed,
        /// compensating for any lost volume
        /// </summary>
        public double LoadingMeter { get; set; }

        /// <summary>
        /// Code of the carrier service in the source system.
        /// This will be translated in the Centiro system to the appropriate Centiro codes
        /// of that carrier service.
        /// If you are using the product ACSS and wish to apply that logic for the shipment,
        /// send in the value "ACSS" in this field.
        /// </summary>
        public string ModeOfTransport { get; set; }

        /// <summary>
        /// In case of participation in the Euro-pallet exchange system;
        /// the number of Euro pallets included in the shipment can be stated here
        /// </summary>
        public int NumberOfEURPallets { get; set; }

        /// <summary>
        /// A route number is used for grouping shipments together based on a route together
        /// with a trip determined by the source system.
        /// This can be used to close shipments at the end of day
        /// </summary>
        public string RouteNumber { get; set; }

        /// <summary>
        /// A trip number is used for grouping shipments together based on a route together
        /// with a trip determined by the source system.
        /// This can be used to close shipments at the end of day day
        /// </summary>
        public string RouteNumberTripNo { get; set; }

        /// <summary>
        /// Printer type format. For ESW it is usually PDF in Ship From Store, ZPL300 in Automation, and ZPL in general Hub.
        /// </summary>
        public string PrinterType { get; set; }

        /// <summary>
        /// Name of site/warehouse/client for internal identification at Centiro.
        /// A sender code is combined concept which equals the ship-from and will be different
        /// based on customer needs.
        /// The sender code is the key identifier which links the source system together with Centiro
        /// </summary>
        public string SenderCode { get; set; }

        /// <summary>
        /// A unique identifier provided by the source system.
        /// Typically a system reference for linking shipments between the system,
        /// not a customer reference.
        /// The shipment identifier is used in other messages as a key identifier
        /// </summary>
        public string ExternalShipmentIdentifier { get; set; }

        /// <summary>
        /// Specifies the type of shipment it is, which can be used to filter shipments
        /// and apply business logic
        /// </summary>
        public ShipmentType ShipmentType { get; set; }

        /// <summary>
        /// Centiro normally generates the tracking number for the shipment,
        /// but if the source system generates the tracking number it should be sent here.
        /// The tracking number is the carrier tracking number, which is the main barcode
        /// on the shipping label and the key identifier in all communication with the carrier.
        /// Can also be referred to as AirWayBill number
        /// </summary>
        public string TrackingNumber { get; set; }

        public string BillingCode { get; set; }

        /// <summary>
        /// The Transport Payers Customer number, this is used for billing.
        /// </summary>
        public string TransportPayerCustomerNumber { get; set; }

        /// <summary>
        /// Can be used, but if not Centiro will summarize the volumes of the parcels
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// Unit of measure for Volume
        /// </summary>
        public VolumeUnitOfMeasure VolumeUnitOfMeasure { get; set; }

        /// <summary>
        /// Can be used, but if not Centiro will summarize the weights of the parcels
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Unit of measure for Weight
        /// </summary>
        public WeightUnitOfMeasure WeightUnitOfMeasure { get; set; }

        /// <summary>
        /// Addresses connected to the shipment
        /// </summary>
        public IReadOnlyList<Address> Addresses { get; set; }

        /// <summary>
        /// Customizable codes to be used in case of standard functionality
        /// not having sufficient support for operations
        /// </summary>
        public IReadOnlyList<Attribute> Attributes { get; set; }

        /// <summary>
        /// Optional services that can typically be applied for multiple different carrier services,
        /// such as saturday delivery or refrigerated
        /// </summary>
        public IReadOnlyList<CarrierServiceAttributes> CarrierServiceAttributes { get; set; }

        /// <summary>
        /// Used to provide information needed for export shipments
        /// </summary>
        public Customs Customs { get; set; }

        /// <summary>
        /// Dates connected to a shipment
        /// </summary>
        public Dates Dates { get; set; }

        public IReadOnlyList<OrderLine> OrderLines { get; set; }

        /// <summary>
        /// Parcels connected to the shipment
        /// </summary>
        public IReadOnlyList<Parcel> Parcels { get; set; }

        public ReceiverReferences ReceiverReferences { get; set; }

        public SenderReferences SenderReferences { get; set; }

        /// <summary>
        /// (sic)
        /// </summary>
        public Charge Cod { get; set; }
    }
}
