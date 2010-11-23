namespace Ninterfaces.IOC
{
    using System;

    public interface IObjectRegistrar
    {
        void Register(Type serviceType, Type implementationType);

        void Register(Type serviceType, Type implementationType, string name);

        void RegisterInstance(Type serviceType, object instance);

        void RegisterInstance(Type serviceType, object instance, string name);

        void RegisterSingleton(Type serviceType, Type implementationType);

        void RegisterSingleton(Type serviceType, Type implementationType, string name);
    }
}
