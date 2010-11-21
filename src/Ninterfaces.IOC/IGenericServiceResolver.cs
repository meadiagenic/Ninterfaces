namespace Ninterfaces.IOC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IGenericServiceResolver
    {
        T Resolve<T>();

        T Resolve<T>(string name);

        IEnumerable<T> ResolveAll<T>();
    }
}
