namespace Ninterfaces.IOC
{
    using System.Collections.Generic;

    public interface IGenericResolver
    {
        TService Resolve<TService>();

        TService Resolve<TService>(string name);

        IEnumerable<TService> ResolveAll<TService>();
    }
}
