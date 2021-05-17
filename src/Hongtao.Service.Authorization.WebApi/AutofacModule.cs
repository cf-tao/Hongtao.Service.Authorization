using Autofac;
using Hongtao.Library.MongoDB;
using Hongtao.Service.Authorization.Core;
using Hongtao.Service.Authorization.WebApi.Repositories;
using Hongtao.Service.Authorization.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hongtao.Service.Authorization.WebApi
{
    public class AutofacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MongoBaseRepository<User>>().As<IMongoBaseRepository<User>>().InstancePerLifetimeScope();

            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
        }
    }
}
