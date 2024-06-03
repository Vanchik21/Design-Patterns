using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLibrary
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("Kiaomi");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("Kiaomi");
        }

        public IDevice CreateEBook()
        {
            return new EBook("Kiaomi");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("Kiaomi");
        }
    }
}
