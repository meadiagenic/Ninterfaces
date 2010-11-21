namespace Ninterfaces.IOC
{
    using System;
    using System.Collections.Generic;

    public interface IObjectResolver
    {
        object Resolve(Type serviceType);

        object Resolve(Type serviceType, string name);

        IEnumerable<object> ResolveAll(Type serviceType);
    }
}
