using Creation.AbstractProduct;

namespace Creation.AbstractFactory
{
    interface IMobileFactory
    {
        IMobile CreateMobile();
        ICharger CreateCharger();
        IHeadphone CreateHeadphone();
    }
}
