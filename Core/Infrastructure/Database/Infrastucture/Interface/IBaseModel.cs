using System.ComponentModel.DataAnnotations;

namespace Core.Infrastructure.Database.Infrastucture.Interface
{
    public interface IBaseModel
    {
        Guid Id { get; set; }
    }
}
