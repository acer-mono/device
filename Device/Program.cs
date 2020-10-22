using System;
using Device.Components;
using Device.Devices;

namespace Device
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            try
            {
                Console.WriteLine("Please, enter device name:");
                var deviceName = Console.ReadLine();
                IDevice device = shop.GetDevice(deviceName);
                Console.WriteLine(device.GetInformation());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}