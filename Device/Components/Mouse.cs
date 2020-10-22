using System;

namespace Device.Components
{
    public class Mouse
    {
        public enum MouseType
        {
            Button2
        }

        private MouseType _buttons;

        public Mouse(MouseType buttons)
        {
            _buttons = buttons;
        }

        public MouseType MouseButtons
        {
            get => _buttons;
            set => _buttons = value;
        }

        public override string ToString()
        {
            return _buttons switch
            {
                MouseType.Button2 => "2-button",
                _ => throw new ArgumentException($"Invalid value _buttons{_buttons.ToString()}")
            };
        }
    }
}