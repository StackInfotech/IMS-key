using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GetKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string macAddresses = "";
            var s = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                macAddresses += nic.GetPhysicalAddress().ToString();
                break;
            }

            Console.WriteLine(macAddresses);
            Console.Read();
        }
    }
}
