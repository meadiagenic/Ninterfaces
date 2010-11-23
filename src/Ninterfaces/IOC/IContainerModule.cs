namespace Ninterfaces.IOC.IOC
{
    using System;

    public interface IContainerModule: IFluent
    {
        void Configure(IContainer container);
    }
}
