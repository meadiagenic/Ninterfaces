using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ninterfaces.IOC
{
    public interface IResolver
    {
        object Resolve(Type serviceType);

        object ResolveNamed(Type serviceType, string name);

        IEnumerable<object> ResolveAll(Type serviceType);
    }
}
