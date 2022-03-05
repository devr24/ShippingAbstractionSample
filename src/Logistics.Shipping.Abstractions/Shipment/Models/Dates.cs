using System;
using System.Collections.Generic;

namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.Dates
    /// </summary>
    public class Dates
    {
        /// <summary>
        /// The dispatch date from consignor location. Date ISO 8601
        /// </summary>
        public DateTime DispatchDate { get; set; }

        /// <summary>
        /// The planned dispatch date from consignor location. Date ISO 8601
        /// </summary>
        public DateTime DispatchDatePlanned { get; set; }

        /// <summary>
        /// Estimated time of arrival (ETA). Date ISO 8601
        /// </summary>
        public DateTime Eta { get; set; }

        /// <summary>
        /// Customer promised date of arrival.Date ISO 8601
        /// </summary>
        public DateTime PromisedDate { get; set; }

        /// <summary>
        /// Defined time window of delivery Date ISO 8601. Needed if a service which require a time window should be used
        /// </summary>
        public DateTime TimeWindowDeliveryFrom { get; set; }

        /// <summary>
        /// Defined time window of delivery Date ISO 8601. Needed if a service which require a time window should be used
        /// </summary>
        public DateTime TimeWindowDeliveryTo { get; set; }

        /// <summary>
        /// Defined time window of pickup.Date ISO 8601
        /// </summary>
        public DateTime TimeWindowPickupFrom { get; set; }

        /// <summary>
        /// Defined time window of pickup. Date ISO 8601
        /// </summary>
        public DateTime TimeWindowPickupTo { get; set; }

        public DateTime EswOrderDate { get; set; }

        public DateTime EswPackageShippedDate { get; set; }

        /// <summary>
        /// Possibility for custom date
        /// </summary>
        public IReadOnlyList<CustomDate> CustomDate { get; set; }
    }
}
