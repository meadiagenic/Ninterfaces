using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninterfaces.IOC
{
    public interface IServiceContainer: IServiceResolver, IDisposable 
    {
        IServiceContainer CreateChildContainer();
    }
}
