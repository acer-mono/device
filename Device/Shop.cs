using System;
using Device.Devices;

namespace Device
{
    public class Shop
    {
        private Laptop _laptop = new Laptop();
        private Desktop _desktop = new Desktop();
        private Notebook _notebook = new Notebook();
        private Tablet _tablet = new Tablet();

        public IDevice GetDevice(string deviceName)
        {
            return deviceName switch
            {
                "Laptop" => _laptop.Clone(),
                "Desktop" => _desktop.Clone(),
                "Notebook" => _notebook.Clone(),
                "Tablet" => _tablet.Clone(),
                _ => throw new ArgumentException($"Sorry, there is no {deviceName} in our store")
            };
        }
    }
}