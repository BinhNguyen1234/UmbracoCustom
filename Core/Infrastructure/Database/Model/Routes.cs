using Core.Infrastructure.Database.Infrastucture.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Infrastructure.Database.Model
{
    [Table("Routes")]
    public class RouteModel : IBaseModel
    {
        [Key]
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Url { get; set; }

    }
}
