using Creation.AbstractFactory;
using Creation.AbstractProduct;
using Creation.ConcreteProduct;

namespace Creation.ConcreteFactory
{
    class MotorolaFactory : IMobileFactory
    {
        ICharger IMobileFactory.CreateCharger()
        {
            return new MotorolaCharger();
        }

        IHeadphone IMobileFactory.CreateHeadphone()
        {
            return new MotorolaHeadphone();
        }

        IMobile IMobileFactory.CreateMobile()
        {
            return new MotorolaMobile();
        }
    }
}
