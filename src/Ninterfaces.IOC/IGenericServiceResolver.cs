﻿namespace Ninterfaces.IOC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IGenericServiceResolver
    {
        TService Resolve<TService>();

        TService Resolve<TService>(string name);

        IEnumerable<TService> ResolveAll<TService>();
    }
}
