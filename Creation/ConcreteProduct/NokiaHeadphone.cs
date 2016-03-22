using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class NokiaHeadphone : IHeadphone
    {
        void IHeadphone.PlayMusic()
        {
            Console.WriteLine("Playing music using Nokia Headphone");
        }
    }
}
