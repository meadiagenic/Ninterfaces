namespace Ninterfaces.IOC
{
    using System;
    using System.Collections.Generic;

    public interface IObjectResolver : IFluent
    {
        bool Contains(Type serviceType);

        bool Contains(Type serviceType, string name);

        object Resolve(Type serviceType);
        
        object Resolve(Type serviceType, string name);

        bool TryResolve(Type serviceType, out object value);

        bool TryResolve(Type serviceType, string name, out object value);

        IEnumerable<object> ResolveAll(Type serviceType);
    }
}
