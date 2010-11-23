namespace Ninterfaces.IOC
{
    using System;

    public interface IRegistrar : IFactoryRegistrar, IGenericRegistrar, IObjectRegistrar, IFluent
    {
    }
}
