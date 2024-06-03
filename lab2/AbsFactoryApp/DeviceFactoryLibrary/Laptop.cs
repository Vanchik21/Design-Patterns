using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLibrary
{
    public class Laptop : IDevice
    {
        private string _brand;

        public Laptop(string brand)
        {
            _brand = brand;
        }

        public string GetDeviceDetails()
        {
            return $"{_brand} Laptop";
        }
    }
}
