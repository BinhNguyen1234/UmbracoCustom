using System.ComponentModel.DataAnnotations;

namespace Core.Data.Infrastucture
{
    public interface IBaseModel
    {
        Guid Id { get; set;  }
    }
}
