namespace Ninterfaces.IOC
{
    using System;

    public interface IContainer: IRegistrar, IResolver, IDisposable, IFluent 
    {
        IContainer CreateChildContainer();
    }
}
