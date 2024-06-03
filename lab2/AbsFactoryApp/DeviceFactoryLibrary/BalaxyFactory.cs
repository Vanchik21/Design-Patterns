using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLibrary
{
    public class BalaxyFactory : IDeviceFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("Balaxy");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("Balaxy");
        }

        public IDevice CreateEBook()
        {
            return new EBook("Balaxy");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("Balaxy");
        }
    }
}
