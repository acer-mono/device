using System;

namespace Device.Components
{
    public class RAM
    {
        public enum RAMSize
        {
            Gb2,
            Gb4,
            Gb8,
            Gb16
        }

        private RAMSize _size;

        public RAM(RAMSize size)
        {
            _size = size;
        }

        public RAMSize Size
        {
            get => _size;
            set => _size = value;
        }

        public override string ToString()
        {
            return _size switch
            {
                RAMSize.Gb2 => "2Gb",
                RAMSize.Gb4 => "4Gb",
                RAMSize.Gb8 => "8Gb",
                RAMSize.Gb16 => "16Gb",
                _ => throw new ArgumentException($"Invalid value _buttons{_size.ToString()}")
            };
        }
    }
}