using Creation.AbstractProduct;
using System;

namespace Creation.ConcreteProduct
{
    class MotorolaMobile : IMobile
    {
        string IMobile.BrandName
        {
            get
            {
                return "Motorola";
            }
        }

        void IMobile.DialNumber(int number)
        {
            Console.WriteLine("Dialing " + number.ToString() + " from a Motorola phone");
        }

        void IMobile.SendMessage(int number, string message)
        {
            Console.WriteLine("Sending msg:" + message + " to " + number.ToString() + " from a Motorola phone");
        }
    }
}
