using Device.Components;

namespace Device.Devices
{
    public class Laptop : IDevice
    {
        public Keyboard Keyboard { get; set; } = new Keyboard(Keyboard.Keys.Keys101);
        public Display Display { get; set; } = new Display(Display.DisplayType.HD);
        public TouchPad TouchPad { get; set; } = new TouchPad(TouchPad.TouchPadType.Button2);
        public CPU Cpu { get; set; } = new CPU(CPU.CPUType.Cores2);
        public RAM Ram { get; set; } = new RAM(RAM.RAMSize.Gb4);
        public ROM Rom { get; set; } = new ROM(ROM.ROMSize.Gb320);
        
        public IDevice Clone()
        {
            return new Laptop()
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
            return "Components of Laptop:\n" +
                   $"Keyboard: {Keyboard}\n" +
                   $"Display: {Display}\n" +
                   $"TouchPad: {TouchPad}\n" +
                   $"CPU: {Cpu}\n" +
                   $"RAM: {Ram}\n" +
                   $"ROM: {Rom}\n";
        }
    }
}