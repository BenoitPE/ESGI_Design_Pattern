﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours1
{
    public class Catalog
    {
        public static int vehicleNumber = 3;
        static void Main(string[] args)
        {
            IVehicleFactory factory = new ElectricVehicleFactory();
            
        }
    }
}
