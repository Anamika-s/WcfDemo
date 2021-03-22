﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HostApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MathsS.Maths));
            host.Open();
            Console.WriteLine("Service has started");
            Console.ReadLine();
            host.Close();
            Console.WriteLine("Servive has stopped");
            Console.ReadLine();
        }
    }
}
