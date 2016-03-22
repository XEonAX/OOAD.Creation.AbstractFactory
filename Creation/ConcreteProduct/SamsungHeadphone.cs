using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class SamsungHeadphone : IHeadphone
    {
        void IHeadphone.PlayMusic()
        {
            Console.WriteLine("Playing music using Samsung Headphone");
        }
    }
}
