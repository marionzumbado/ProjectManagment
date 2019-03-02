using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using ProjectManagment.DAL;
using ProjectManagment.Models;
using ProjectManagment.Profiles;
using ProjectManagment.Services;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjectManagment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterAutofac();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureAutoMapper();
        }

        private void RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                foreach (var profile in context.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IRepository<User>>();
            builder.RegisterType<UserProjectRepository>().As<IRepository<UserProject>>();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private void ConfigureAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ProjectProfile>();
                cfg.AddProfile<UserProfile>();
            });
        }
    }
}
