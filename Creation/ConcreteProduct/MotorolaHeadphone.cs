using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class MotorolaHeadphone : IHeadphone
    {
        void IHeadphone.PlayMusic()
        {
            Console.WriteLine("Playing music using Motorola Headphone");
        }
    }
}
