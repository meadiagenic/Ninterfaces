using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninterfaces.IOC
{
    public interface IGenericRegistrar
    {
        void Register<TService, TImplementation>() where TService : TImplementation;

        void Register<TService, TImplementation>(string name) where TService : TImplementation;

        void RegisterInstance<TService>(TService instance);

        void RegisterInstanceNamed<TService>(TService instance);
    }
}
