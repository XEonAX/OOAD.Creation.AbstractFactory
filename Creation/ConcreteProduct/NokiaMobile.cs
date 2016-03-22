using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class NokiaMobile : IMobile
    {
        string IMobile.BrandName
        {
            get
            {
                return "Nokia";
            }
        }

        void IMobile.DialNumber(int number)
        {
            Console.WriteLine("Dialing " + number.ToString() + " from a Nokia phone");
        }

        void IMobile.SendMessage(int number, string message)
        {
            Console.WriteLine("Sending msg:" + message + " to " + number.ToString() + " from a Nokia phone");
        }
    }
}
