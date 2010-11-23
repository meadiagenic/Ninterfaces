namespace Ninterfaces.IOC
{
    using System;

    public interface IFactoryRegistrar : IFluent
    {
        void RegisterFactory<TService>(Func<TService> factory);

        void RegisterFactory<TService>(string name, Func<TService> factory);

        void RegisterFactory<TService>(Func<IResolver, TService> factory);

        void RegisterFactory<TService>(string name, Func<IResolver, TService> factory);

        void RegisterFactory<TArg, TService>(Func<IResolver, TArg, TService> factory);

        void RegisterFactory<TArg1, TArg2, TService>(Func<IResolver, TArg1, TArg2, TService> factory);

        void RegisterFactory<TArg1, TArg2, TArg3, TService>(Func<IResolver, TArg1, TArg2, TArg3, TService> factory);
    }
}
