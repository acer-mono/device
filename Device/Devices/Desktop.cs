using Device.Components;

namespace Device.Devices
{
    public class Desktop : IDevice
    {
        public Mouse Mouse { get; set; } = new Mouse(Mouse.MouseType.Button2);
        public CPU Cpu { get; set; } = new CPU(CPU.CPUType.Cores4);
        public RAM Ram { get; set; } = new RAM(RAM.RAMSize.Gb16);
        public ROM Rom { get; set; } = new ROM(ROM.ROMSize.Tb1);

        public IDevice Clone()
        {
            return new Desktop()
            {
                Mouse = new Mouse(Mouse.MouseButtons),
                Cpu = new CPU(Cpu.Cores),
                Ram = new RAM(Ram.Size),
                Rom = new ROM(Rom.Size)
            };
        }

        public string GetInformation()
        {
            return "Components of Desktop:\n" +
                   $"Mouse: {Mouse}\n" +
                   $"CPU: {Cpu}\n" +
                   $"RAM: {Ram}\n" +
                   $"ROM: {Rom}\n";
        }
    }
}