using Autofac;

namespace GondorCars.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}