namespace Ninterfaces.IOC
{
    using System;
using System.ComponentModel;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IFluent
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        bool Equals(object obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        Type GetType();
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        string ToString();
    }
}
