namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.Customs
    ///
    /// Used to provide information needed for export shipments
    /// </summary>
    public class Customs
    {
        /// <summary>
        /// Specifies the value of the entire shipment.
        /// This value is used for customs clearance purposes.
        /// Required for international/cross-border shipments.
        /// Mandatory for exports
        /// </summary>
        public double ShipmentValue { get; set; }

        /// <summary>
        /// Specifies the currency used for the shipment value.
        /// This value is used for customs clearance purposes.
        /// Required for international/cross-border shipments.
        /// Mandatory for exports
        /// </summary>
        public string ShipmentValueCurrency { get; set; }

        /// <summary>
        /// This field is used differently depending on shipment origin,
        /// but it specifies a customs number required to export the shipment.
        /// In the US this equals the AES code required for shipments
        /// with a value higher than $2 500.
        /// </summary>
        public string ExportLicenseNumber { get; set; }

        /// <summary>
        /// The Incoterms rules or International Commercial Terms are a series of pre-defined
        /// commercial terms published by the International Chamber of Commerce (ICC)"(wikipedia, Incoterms).
        /// Mandatory for exports
        /// </summary>
        public string TermsOfDelivery { get; set; }

        /// <summary>
        /// The location related to the specified terms of delivery.
        /// Certain incoterms do require a location to specified as well
        /// for example a harbor in which the handover of responsibility is made.
        /// Mandatory for exports
        /// </summary>
        public string TermsOfDeliveryLocation { get; set; }

        /// <summary>
        /// The reason for exporting a shipment which will be used for customs clearance purposes.
        /// Mandatory for exports
        /// </summary>
        public string ExportReasonCode { get; set; }

        /// <summary>
        /// If the export reason code other is used, an export reason must be provided.
        /// Mandatory for exports
        /// </summary>
        public string ExportReason { get; set; }
    }
}
