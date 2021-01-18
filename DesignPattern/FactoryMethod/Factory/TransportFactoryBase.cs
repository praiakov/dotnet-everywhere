using FactoryMethod.Enum;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Factory
{
    public abstract class TrasnportFactoryBase
    {
        abstract public ITransport GetTransport(Transport transportType);
    }
}
