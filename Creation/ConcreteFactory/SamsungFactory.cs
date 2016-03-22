using Creation.AbstractFactory;
using Creation.AbstractProduct;
using Creation.ConcreteProduct;

namespace Creation.ConcreteFactory
{
    class SamsungFactory : IMobileFactory
    {
        ICharger IMobileFactory.CreateCharger()
        {
            return new SamsungCharger();
        }

        IHeadphone IMobileFactory.CreateHeadphone()
        {
            return new SamsungHeadphone();
        }

        IMobile IMobileFactory.CreateMobile()
        {
            return new SamsungMobile();
        }
    }
}
