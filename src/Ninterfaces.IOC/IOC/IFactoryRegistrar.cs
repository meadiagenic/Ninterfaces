namespace Ninterfaces.IOC
{
    using System;

    public interface IFactoryRegistrar
    {
        void RegisterFactory<TService>(Func<TService> factory);

        void RegisterFactory<TService>(Func<TService> factory, string name);
    }
}
