using Hongtao.Service.Authorization.Core;
using Hongtao.Service.Authorization.WebApi.Models;
using Hongtao.Service.Authorization.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hongtao.Service.Authorization.WebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private IUserService userService { get; set; }

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<User> RegisterAsync(RegisterRequest user)
        {
            return await userService.Register(user);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IList<User>> GetAllAsync()
        {
            return await userService.GetAllAsync();
        }

        [HttpGet]
        [Route("")]
        public async Task<User> GetAll(Guid id)
        {
            return await userService.GetAsync(id);
        }
    }
}