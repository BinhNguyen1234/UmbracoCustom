using Core.DTO.RequesModel;
using Core.Entities;
using Core.Infrastructure.Database.Infrastucture;
using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Database.Repositories
{
    public class UserRepository : GenericRepositoryBase<User>, IUserRepository
    {
        public UserRepository(CoreContext dbContext) : base(dbContext){}

        public async Task<int> AddUser(User user)
        {
            await this._dbSet.AddAsync(user);
            return await this.SaveChangeAsync();
        }
        public async Task<User?> LookUpUser(UserEntity user) {
            return await this._dbSet.FirstOrDefaultAsync(x => x.Email.ToLower().Equals(user.Email.ToLower()));
        }
        public async Task<bool> IsAnyUser(UserEntity user)
        {
            return await this._dbSet.AnyAsync(x => x.Email.ToLower().Equals(user.Email.ToLower()));
        }
        
    }
}
