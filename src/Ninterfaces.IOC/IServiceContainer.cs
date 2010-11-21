namespace Ninterfaces.IOC
{
    using System;

    public interface IServiceContainer: IResolver, IDisposable 
    {
        IServiceContainer CreateChildContainer();
    }
}
