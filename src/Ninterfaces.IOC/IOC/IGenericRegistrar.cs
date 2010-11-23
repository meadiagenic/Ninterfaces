namespace Ninterfaces.IOC
{
    public interface IGenericRegistrar
    {
        void Register<TService, TImplementation>() where TService : TImplementation;

        void Register<TService, TImplementation>(string name) where TService : TImplementation;

        void RegisterInstance<TService>(TService instance) where TService : class;

        void RegisterInstance<TService>(TService instance, string name) where TService : class;

        void RegisterSingleton<TService, TImplementation>() where TService : TImplementation;

        void RegisterSingleton<TService, TImplementation>(string name) where TService : TImplementation;


    }
}
