using Creation.AbstractFactory;
using Creation.AbstractProduct;
using Creation.ConcreteProduct;

namespace Creation.ConcreteFactory
{
    class NokiaFactory : IMobileFactory
    {
        ICharger IMobileFactory.CreateCharger()
        {
            return new NokiaCharger();
        }

        IHeadphone IMobileFactory.CreateHeadphone()
        {
            return new NokiaHeadphone();
        }

        IMobile IMobileFactory.CreateMobile()
        {
            return new NokiaMobile();
        }
    }
}
