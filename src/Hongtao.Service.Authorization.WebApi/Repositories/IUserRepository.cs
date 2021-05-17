using Hongtao.Service.Authorization.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hongtao.Service.Authorization.WebApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateAsync(User user);

        Task<User> GetAsync(Guid id);

        Task<IList<User>> GetAllAsync();
    }
}