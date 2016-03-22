using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class SamsungCharger : ICharger
    {
        void ICharger.ChargePhone(IMobile Mobile)
        {
            Console.WriteLine("Charging a " + Mobile.BrandName + " phone with a Samsung Charger");
        }
    }
}
