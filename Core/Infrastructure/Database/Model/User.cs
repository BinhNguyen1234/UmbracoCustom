using Core.Infrastructure.Database.Infrastucture.Interface;
using System.ComponentModel.DataAnnotations;

namespace Core.Infrastructure.Database.Model
{
    public class User : IBaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
