namespace Ninterfaces.IOC
{
    using System;

    public interface IObjectRegistrar : IFluent
    {
        void Register(Type serviceType, Type implementationType);

        void Register(string name, Type serviceType, Type implementationType);

        void RegisterInstance(Type serviceType, object instance);

        void RegisterInstance(string name, Type serviceType, object instance);

        void RegisterSingleton(Type serviceType, Type implementationType);

        void RegisterSingleton(string name, Type serviceType, Type implementationType);
    }
}
