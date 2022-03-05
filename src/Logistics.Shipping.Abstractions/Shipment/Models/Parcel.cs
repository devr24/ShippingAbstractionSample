using Logistics.Shipping.Abstractions.Shipping.Models;
using System.Collections.ObjectModel;

namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.Parcel
    /// </summary>
    public class Parcel
    {
        /// <summary>
        /// Customizable codes to be used for customized functionality
        /// </summary>
        public IReadOnlyList<Attribute> Attributes { get; set; } = new Collection<Attribute>();

        /// <summary>
        /// The height of the parcel
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Used to convert the height to standard unit Allowed values:
        /// mm, cm, m, in, ft (Millimeter, Centimeter, Meter, Inch, Foot)
        /// </summary>
        public DimensionUnitOfMeasure HeightUnitOfMeasure { get; set; }

        /// <summary>
        /// The length of the parcel
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Unit of measure for Length .
        /// </summary>
        public DimensionUnitOfMeasure LengthUnitOfMeasure { get; set; }

        /// <summary>
        /// A loading metre corresponds to one linear meter of loading space in a truck.
        /// This is used as a calculation unit for goods that cannot be stacked or when
        /// stacking of or on top of these goods is not allowed, compensating for any lost volume
        /// </summary>
        public double LoadingMeter { get; set; }

        /// <summary>
        /// The net weight of the content without its package,
        /// used as a secondary weight for reports or similar.
        /// Typically not communicated to the carrier unless required.
        /// Uses same unit of measure as
        /// </summary>
        public double NetWeight { get; set; }

        /// <summary>
        /// A unique identifier provided by the source system.
        /// Typically a system reference for linking parcels between the system,
        /// not a customer reference.
        /// The parcel identifier is used in other messages as a key identifier
        /// </summary>
        public string ExternalParcelIdentifier { get; set; }

        /// <summary>
        /// Centiro normally generates the tracking number for the shipment,
        /// but if the source system generates the tracking number it should be sent here.
        /// The tracking number is the carrier tracking number,
        /// which is the main barcode on the shipping label and the key identifier
        /// in all communication with the carrier
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The tracking number SSCC is a specific type of tracking range
        /// using the SSCC format as specified and provided by GS1
        /// and should only be populated in the cases where the source system
        /// is responsible for carrier tracking number generation.
        /// https://www.gs1.org/serial-shipping-container-code-sscc
        /// </summary>
        public string TrackingNumberSSCC { get; set; }

        /// <summary>
        /// The type of goods sent in the package.
        /// This value is normally mandated by the carrier to be present
        /// and is expected to be a generalization of the content
        /// </summary>
        public string TypeOfGoods { get; set; }

        /// <summary>
        /// The package type used.
        /// This value will be translated for carriers that requires it.
        /// For example if the package type is a pallet,
        /// or half-pallet or if the carrier have specific packaging material that is being used.
        /// </summary>
        public string TypeOfPackage { get; set; }

        public double Volume { get; set; }

        /// <summary>
        /// Allowed values: m3, cm3, mm3, in3 or ft3
        /// (Cubic meter, Cubic centimeter, Cubic millimeter, Cubic inch, Cubic feet)
        /// </summary>
        public VolumeUnitOfMeasure VolumeUnitOfMeasure { get; set; }

        /// <summary>
        /// The weight of the individual parcel
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Used to convert the weight to standard unit
        /// Allowed values: kg, g, oz or lbs(Kilogram, Gram, Ounce, Pound)
        /// </summary>
        public WeightUnitOfMeasure WeightUnitOfMeasure { get; set; }

        /// <summary>
        /// The width of the individual parcel
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Used to convert the width to standard unit
        /// Allowed values: mm, cm, m, in, ft (Millimeter, Centimeter, Meter, Inch, Foot)
        /// </summary>
        public DimensionUnitOfMeasure WidthUnitOfMeasure { get; set; }

        /// <summary>
        /// Receiver references
        /// </summary>
        public ReceiverReferences ReceiverReferences { get; set; }

        /// <summary>
        /// Sender references
        /// </summary>
        public SenderReferences SenderReferences { get; set; }

        /// <summary>
        /// Order lines connected to the parcel
        /// </summary>
        public IReadOnlyList<ParcelOrderLine> OrderLines { get; set; }

        public double GoodsValue { get; set; }

        public double VolumetricWeight { get; set; }

        public string VolumetricWeightUnit { get; set; }

        public string DistributionCentre { get; set; }
    }
}
