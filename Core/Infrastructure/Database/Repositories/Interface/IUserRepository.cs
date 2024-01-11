using Core.DTO.RequesModel;
using Core.Entities;
using Core.Infrastructure.Database.Model;

namespace Core.Infrastructure.Database.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<int> AddUser(User user);
        Task<bool> IsAnyUser(UserEntity user);
        Task<User?> LookUpUser(UserEntity user);
    }
}
