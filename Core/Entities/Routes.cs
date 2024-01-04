using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class RouteEntites
    {
        [MaxLength(15)]
        public required string name { get; set; }
        public required string url { get; set; }
    }
}
