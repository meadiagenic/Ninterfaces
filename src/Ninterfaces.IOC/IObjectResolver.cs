using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ninterfaces.IOC
{
    public interface IObjectResolver
    {
        object Resolve(Type serviceType);

        object Resolve(Type serviceType, string name);

        IEnumerable<object> ResolveAll(Type serviceType);
    }
}
