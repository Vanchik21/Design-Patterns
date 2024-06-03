using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLibrary
{
    public class Netbook : IDevice
    {
        private string _brand;

        public Netbook(string brand)
        {
            _brand = brand;
        }

        public string GetDeviceDetails()
        {
            return $"{_brand} Netbook";
        }
    }
}
