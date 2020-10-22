using System;

namespace Device.Components
{
    public class CPU
    {
        public enum CPUType
        {
            Cores2,
            Cores4,
            Cores8
        }

        private CPUType _cores;

        public CPU(CPUType cores)
        {
            _cores = cores;
        }

        public CPUType Cores
        {
            get => _cores;
            set => _cores = value;
        }

        public override string ToString()
        {
            return _cores switch
            {
                CPUType.Cores2 => "2cores",
                CPUType.Cores4 => "4cores",
                CPUType.Cores8 => "8cores",
                _ => throw new ArgumentException($"Invalid value _buttons{_cores.ToString()}")
            };
        }
    }
}