using Device.Components;

namespace Device.Devices
{
    public class Notebook : IDevice
    {
        public Keyboard Keyboard { get; set; } = new Keyboard(Keyboard.Keys.Keys108);
        public Display Display { get; set; } = new Display(Display.DisplayType.FullHD);
        public TouchPad TouchPad { get; set; } = new TouchPad(TouchPad.TouchPadType.Button1);
        public CPU Cpu { get; set; } = new CPU(CPU.CPUType.Cores2);
        public RAM Ram { get; set; } = new RAM(RAM.RAMSize.Gb8);
        public ROM Rom { get; set; } = new ROM(ROM.ROMSize.Gb512);
        public IDevice Clone()
        {
            return new Notebook()
            {
                Keyboard = new Keyboard(Keyboard.KeyboardType),
                Display = new Display(Display.DisplayDefinition),
                TouchPad = new TouchPad(TouchPad.TouchPadButtons),
                Cpu = new CPU(Cpu.Cores),
                Ram = new RAM(Ram.Size),
                Rom = new ROM(Rom.Size)
            };
        }

        public string GetInformation()
        {
            return "Components of Notebook:\n" +
                   $"Keyboard: {Keyboard}\n" +
                   $"Display: {Display}\n" +
                   $"TouchPad: {TouchPad}\n" +
                   $"CPU: {Cpu}\n" +
                   $"RAM: {Ram}\n" +
                   $"ROM: {Rom}\n";
        }
    }
}