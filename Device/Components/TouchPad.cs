using System;

namespace Device.Components
{
    public class TouchPad
    {
        public enum TouchPadType
        {
            Button2,
            Button1
        }

        private TouchPadType _buttons;

        public TouchPad(TouchPadType buttons)
        {
            _buttons = buttons;
        }

        public TouchPadType TouchPadButtons
        {
            get => _buttons;
            set => _buttons = value;
        }

        public override string ToString()
        {
            return _buttons switch
            {
                TouchPadType.Button2 => "2-button",
                TouchPadType.Button1 => "1-button",
                _ => throw new ArgumentException($"Invalid value _buttons{_buttons.ToString()}")
            };
        }
    }
}