using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class SamsungMobile : IMobile
    {
        string IMobile.BrandName
        {
            get
            {
                return "Samsung";
            }
        }

        void IMobile.DialNumber(int number)
        {
            Console.WriteLine("Dialing " + number.ToString() + " from a Samsung phone");
        }

        void IMobile.SendMessage(int number, string message)
        {
            Console.WriteLine("Sending msg:" + message + " to " + number.ToString() + " from a Samsung phone");
        }
    }
}
