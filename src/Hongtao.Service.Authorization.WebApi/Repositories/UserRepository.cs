using Hongtao.Library.MongoDB;
using Hongtao.Service.Authorization.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hongtao.Service.Authorization.WebApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IMongoBaseRepository<User> mongobaseRepo { get; set; }

        public UserRepository(IMongoBaseRepository<User> mongobaseRepo)
        {
            this.mongobaseRepo = mongobaseRepo;
        }

        public async Task<User> CreateAsync(User user)
        {
            return await mongobaseRepo.CreateAsync(user);
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await mongobaseRepo.GetAsync(id.ToString());
        }

        public async Task<IList<User>> GetAllAsync()
        {
            return await mongobaseRepo.GetAllAsync();
        }
    }
}