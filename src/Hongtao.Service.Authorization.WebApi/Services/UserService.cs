using AutoMapper;
using Hongtao.Service.Authorization.Core;
using Hongtao.Service.Authorization.WebApi.Models;
using Hongtao.Service.Authorization.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hongtao.Service.Authorization.WebApi.Services
{
    public class UserService : IUserService
    {
        private IUserRepository repository { get; set; }
        private IMapper mapper { get; set; }

        public UserService(IUserRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<User> Register(RegisterRequest request)
        {
            var user = mapper.Map<User>(request);
            return await repository.CreateAsync(user);
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await repository.GetAsync(id);
        }

        public async Task<IList<User>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }
    }
}