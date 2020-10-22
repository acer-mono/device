using System;

namespace Device.Components
{
    public class Display
    {
        public enum DisplayType
        {
            HD,
            FullHD,
            UltraHD
        }

        private DisplayType _display;

        public Display(DisplayType displayType)
        {
            _display = displayType;
        }

        public DisplayType DisplayDefinition
        {
            get => _display;
            set => _display = value;
        }

        public override string ToString()
        {
            return _display switch
            {
                DisplayType.HD => "HD",
                DisplayType.FullHD => "FullHD",
                DisplayType.UltraHD => "UltraHD",
                _ => throw new ArgumentException($"Invalid value _display{_display.ToString()}")
            };
        }
    }
}