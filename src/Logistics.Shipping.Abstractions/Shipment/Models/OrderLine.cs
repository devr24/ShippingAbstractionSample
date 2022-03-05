using System.Collections.Generic;

namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.OrderLine
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Customizable codes to be used for customized functionality
        /// </summary>
        public IReadOnlyList<Attribute> Attributes { get; set; }

        /// <summary>
        /// The origin country of the item in question. ISO 3166-1 alpha 2.
        /// Mandatory for exports to your customer either on Shipment or Parcel level
        /// </summary>
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// To be used in subsequent carrier integrations as export information
        /// regarding items included in shipments.
        /// Can also be used in printing delivery notes and waybills.
        /// Mandatory for exports to your customer either on Shipment or Parcel level
        /// </summary>
        public string ItemDescription1 { get; set; }

        /// <summary>
        /// To be used as additional information describing the item from <see cref="ItemDescription1"/>.
        /// </summary>
        public string ItemDescription2 { get; set; }

        /// <summary>
        /// To be used as additional information describing the item from <see cref="ItemDescription1"/>.
        /// </summary>
        public string ItemDescription3 { get; set; }

        /// <summary>
        /// Product number of the item in question.
        /// </summary>
        public string ProductNumber { get; set; }

        /// <summary>
        /// Number of units of the given item that is being shipped
        /// </summary>
        public int QuantityShipped { get; set; }

        /// <summary>
        /// Statistical number refer to the international standardized system of names and numbers
        /// for the classification of products. Can also be referred to as Statistical Code,
        /// Harmonized Code, Goods code or Tarrif Code and are used in import duties,
        /// trade statistics, origin regulations etc.
        /// Mandatory for exports to your customer either on Shipment or Parcel level
        /// </summary>
        public string StatisticalNumber { get; set; }

        /// <summary>
        /// The total volume of all included items as an aggregated measure
        /// </summary>
        public double TotalVolume { get; set; }

        /// <summary>
        /// Unit of measure for TotalVolume
        /// </summary>
        public VolumeUnitOfMeasure TotalVolumeUnitOfMeasure { get; set; }

        /// <summary>
        /// The total weight of all included items as an aggregated measure
        /// </summary>
        public double TotalWeight { get; set; }

        /// <summary>
        /// Unit of measure for TotalWeight
        /// </summary>
        public WeightUnitOfMeasure TotalWeightUnitOfMeasure { get; set; }

        /// <summary>
        /// The total value of all included items as an aggregated measure
        /// </summary>
        public double TotalValue { get; set; }

        /// <summary>
        /// Currency of TotalValue
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Value of a single item
        /// </summary>
        public double UnitValue { get; set; }

        /// <summary>
        /// Volume of a single item
        /// </summary>
        public double UnitVolume { get; set; }

        /// <summary>
        /// Unit of measure for UnitVolume
        /// </summary>
        public VolumeUnitOfMeasure UnitVolumeUnitOfMeasure { get; set; }

        /// <summary>
        /// Weight of a single item.
        /// Mandatory for exports to your customer either on Shipment or Parcel level
        /// </summary>
        public double UnitWeight { get; set; }

        /// <summary>
        /// Unit of measure for UnitWeight
        /// </summary>
        public WeightUnitOfMeasure UnitWeightUnitOfMeasure { get; set; }

        /// <summary>
        /// Related to how you sell the product, for example '22meter hose' or 'packet'.
        /// Connected to QuantityShipped
        /// </summary>
        public string UnitMeasure { get; set; }
    }
}
