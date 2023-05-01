using Autofac;
using AutoMapper;
using GondorCars.Application;
using GondorCars.Application.Interface;
using GondorCars.Domain.Core.Interfaces.Repositories;
using GondorCars.Domain.Service;
using GondorCars.Infrastructure.Data.Repositories;

namespace GondorCars.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCar>().As<IApplicationServiceCar>();
            builder.RegisterType<CarService>().As<CarService>();
            builder.RegisterType<RepositoryCar>().As<IRepositoryCar>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile(new DtoToModelMappingCliente());
                //cfg.AddProfile(new ModelToDtoMappingCliente());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }
}