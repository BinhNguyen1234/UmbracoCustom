using System.ComponentModel.DataAnnotations;

namespace Core.BlogModel
{
    public class Route
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public required string NameRoute { get; set; }
        [Required]
        public required string Url { get; set; }
    }
}
