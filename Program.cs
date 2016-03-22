using Creation.AbstractFactory;
using Creation.AbstractProduct;
using Creation.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var userinput = "";
            WhichCompany();
            userinput = Console.ReadLine();
            int companyid;
            IMobileFactory factory;
            while (int.TryParse(userinput, out companyid))
            {
                #region AbstractFactory
                switch (companyid)
                {
                    case 1:
                        factory = new NokiaFactory();
                        break;
                    case 2:
                        factory = new MotorolaFactory();
                        break;
                    case 3:
                        factory = new SamsungFactory();
                        break;
                    default:
                        factory = null;
                        break;
                }
                #endregion

                if (factory != null)
                {
                    WhatToMake();
                    userinput = Console.ReadLine();
                    int productid;
                    while (int.TryParse(userinput, out productid))
                    {
                        #region AbstractProduct
                        switch (productid)
                        {
                            case 1:
                                IMobile mobile = factory.CreateMobile();
                                mobile.DialNumber(123456789);
                                break;
                            case 2:
                                ICharger charger = factory.CreateCharger();
                                charger.ChargePhone(factory.CreateMobile());
                                break;
                            case 3:
                                IHeadphone headphone = factory.CreateHeadphone();
                                headphone.PlayMusic();
                                break;
                            default:
                                
                                break;
                        }
                        #endregion
                        WhatToMake();
                        userinput = Console.ReadLine();
                    }
                }

                WhichCompany();
                userinput = Console.ReadLine();
            }
        }

        private static void WhichCompany()
        {
            Console.WriteLine("Which company do you belong to?");
            Console.WriteLine("1) Nokia");
            Console.WriteLine("2) Motorola");
            Console.WriteLine("3) Samsung");
            Console.WriteLine("X) Return");
        }
        private static void WhatToMake()
        {
            Console.WriteLine("Which do you want to make and test?");
            Console.WriteLine("1) Mobile");
            Console.WriteLine("2) Charger");
            Console.WriteLine("3) Headphone");
            Console.WriteLine("X) Return");
        }
    }
}

