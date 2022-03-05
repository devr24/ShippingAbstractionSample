using System.ComponentModel.DataAnnotations;

namespace Logistics.Shipping.Abstractions.Pudo.Models
{
    public class PudoLocationSearch
    {
        [Required]
        [StringLength(20)]
        public string CarrierId { get; init; }

        [Required]
        [StringLength(3)]
        public string CountryIso { get; init; }

        [Required]
        [StringLength(20)]
        public string PostalCode { get; init; }

        [StringLength(30)]
        public string City { get; init; }

        public double? Longitude { get; init; }

        public double? Latitude { get; init; }

        public int? MaxDistanceInKilometers { get; init; }
        public int? MaxLocations { get; init; }
    }

}
