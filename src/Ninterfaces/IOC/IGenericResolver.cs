namespace Ninterfaces.IOC
{
    using System.Collections.Generic;

    public interface IGenericResolver
    {
        bool Contains<TService>();

        bool Contains<TService>(string name);

        TService Resolve<TService>();

        TService Resolve<TService>(string name);

        IEnumerable<TService> ResolveAll<TService>();

        bool TryResolve<TService>(out TService value);

        bool TryResolve<TService>(string name, out TService value);
    }
}
