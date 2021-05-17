using Hongtao.Service.Authorization.Core;
using Hongtao.Service.Authorization.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hongtao.Service.Authorization.WebApi.Services
{
    public interface IUserService
    {
        Task<User> Register(RegisterRequest user);

        Task<User> GetAsync(Guid id);

        Task<IList<User>> GetAllAsync();
    }
}