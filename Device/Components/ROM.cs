using System;

namespace Device.Components
{
    public class ROM
    {
        public enum ROMSize
        {
            Gb128,
            Gb320,
            Gb512,
            Tb1
        }

        private ROMSize _size;

        public ROM(ROMSize size)
        {
            _size = size;
        }

        public ROMSize Size
        {
            get => _size;
            set => _size = value;
        }

        public override string ToString()
        {
            return _size switch
            {
                ROMSize.Gb128 => "128Gb",
                ROMSize.Gb320 => "320Gb",
                ROMSize.Gb512 => "512Gb",
                ROMSize.Tb1 => "1Tb",
                _ => throw new ArgumentException($"Invalid value _buttons{_size.ToString()}")
            };
        }
    }
}