using FactoryMethod.Interfaces;

namespace FactoryMethod.Factory
{
    public class Truck : ITransport
    {
        public string Deliver(int miles)
        {
            return $"O valor para o transporte de caminhão é {miles * 2}";
        }
    }
}
