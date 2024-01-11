using Core.DTO.RequesModel;

namespace Core.Services.Interface
{
    public interface IUserService
    {
        Task<bool> RegistUser(RegisterForm registerForm);
    }
}
