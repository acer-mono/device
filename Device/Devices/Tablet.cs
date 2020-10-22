using Device.Components;

namespace Device.Devices
{
    public class Tablet : IDevice
    {
        public Display Display { get; set; } = new Display(Display.DisplayType.UltraHD);
        public CPU Cpu { get; set; } = new CPU(CPU.CPUType.Cores8);
        public RAM Ram { get; set; } = new RAM(RAM.RAMSize.Gb2);
        public ROM Rom { get; set; } = new ROM(ROM.ROMSize.Gb128);

        public IDevice Clone()
        {
            return new Tablet()
            {
                Display = new Display(Display.DisplayDefinition),
                Cpu = new CPU(Cpu.Cores),
                Ram = new RAM(Ram.Size),
                Rom = new ROM(Rom.Size)
            };
        }

        public string GetInformation()
        {
            return "Components of Tablet:\n" +
                   $"Display: {Display}\n" +
                   $"CPU: {Cpu}\n" +
                   $"RAM: {Ram}\n" +
                   $"ROM: {Rom}\n";
        }
    }
}