using System;
using DeviceFactoryLibrary;

namespace AbsFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceFactory iproneFactory = new IProneFactory();
            IDeviceFactory kiaomiFactory = new KiaomiFactory();
            IDeviceFactory balaxyFactory = new BalaxyFactory();

            IDevice iproneLaptop = iproneFactory.CreateLaptop();
            IDevice kiaomiSmartphone = kiaomiFactory.CreateSmartphone();
            IDevice balaxyEBook = balaxyFactory.CreateEBook();

            Console.WriteLine(iproneLaptop.GetDeviceDetails());
            Console.WriteLine(kiaomiSmartphone.GetDeviceDetails());
            Console.WriteLine(balaxyEBook.GetDeviceDetails());
        }
    }
}