namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.Address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Additional address information
        /// </summary>
        public string AdditionalAddressInformation1 { get; set; }

        /// <summary>
        /// Additional address information
        /// </summary>
        public string AdditionalAddressInformation2 { get; set; }

        public AddressType AddressType { get; set; }

        /// <summary>
        /// "Customer number connected to the AddressType,
        /// for example the Receiver's or Sender's customer number.
        /// Not to be confused with carrier account number"
        /// </summary>
        public string ExternalAddressIdentifier { get; set; }

        /// <summary>
        /// Contact cell phone number
        /// </summary>
        public string CellPhone { get; set; }

        /// <summary>
        /// Name of city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Name of contact person
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Carrier account number connected to this address
        /// </summary>
        public string CarrierAccountNumber { get; set; }

        /// <summary>
        /// Contact email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contact fax number
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Country code, two characters. ISO 3166-1 alpha 2
        /// </summary>
        public string IsoCountry { get; set; }

        /// <summary>
        /// Name of person or company
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contact phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Indicates if address is residential or commercial
        /// </summary>
        public bool Residential { get; set; }

        /// <summary>
        /// If needed title to address either or see
        /// </summary>
        public string Salutation { get; set; }

        /// <summary>
        /// Subdivision code, two characters. ISO 3166-1 alpha 2
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Street address
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// Can also be provided in StreetAddress if a split is not desirable
        /// </summary>
        public string StreetAddressHouseNumber { get; set; }

        /// <summary>
        /// Value added tax identification number
        /// </summary>
        public string VatNumber { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        public string ZipCode { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }
}
