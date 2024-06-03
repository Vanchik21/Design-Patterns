using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLibrary
{
    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("IProne");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("IProne");
        }

        public IDevice CreateEBook()
        {
            return new EBook("IProne");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("IProne");
        }
    }
}
