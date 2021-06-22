using System.ComponentModel.DataAnnotations;

namespace Vulder.Search.Api.Models
{
    public class SchoolDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Url { get; set; }
        
        public string RequesterEmail { get; set; }
    }
}