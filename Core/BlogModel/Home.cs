using System.ComponentModel.DataAnnotations;

namespace Core.BlogModel
{
    public class Home
    {
        [Key]
        public int HomeId { get; set; }
        public required string Address { get; set; }
    }
}
