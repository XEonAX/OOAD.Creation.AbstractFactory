using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class NokiaCharger : ICharger
    {
        void ICharger.ChargePhone(IMobile Mobile)
        {
            Console.WriteLine("Charging a " + Mobile.BrandName + " phone with a Nokia Charger");
        }

    }
}
