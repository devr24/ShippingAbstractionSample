using System.ComponentModel.DataAnnotations;

namespace Logistics.Shipping.Api.Models
{
    [Display(Name = "PudoLocationSearch")]
    public class PudoLocationSearchDto
    {
        [Required]
        public string Origin { get; set; }
        
        [Required]
        public string Destination { get; set; }
    }

    [Display(Name = "PudoSearchResults")]
    public class PudoSearchResultsDto
    {
        public List<string> Results { get; set; }
    }
}
