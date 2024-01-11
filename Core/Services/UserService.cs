using AutoMapper;
using Core.DTO.RequesModel;
using Core.Entities;
using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories.Interface;
using Core.Infrastructure.Services.Cms;
using Core.Services.Interface;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, ICmsService cmsService, IMapper mapper)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        public async Task<bool> RegistUser(RegisterForm registerForm)
        {
            try
            {
                var user = this._mapper.Map<UserEntity>(registerForm);
                var rs = await this._userRepository.IsAnyUser(user);
                if (!rs)
                {
                    var newUser = this._mapper.Map<User>(user);
                    await this._userRepository.AddUser(newUser);
                }
                return false;
            } catch
            {
                throw;
            }
        }
    }
}
