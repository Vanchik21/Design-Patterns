﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLibrary
{
    public class Smartphone : IDevice
    {
        private string _brand;

        public Smartphone(string brand)
        {
            _brand = brand;
        }

        public string GetDeviceDetails()
        {
            return $"{_brand} Smartphone";
        }
    }
}
