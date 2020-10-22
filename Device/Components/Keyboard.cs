using System;

namespace Device.Components
{
    public class Keyboard
    {
        public enum Keys
        {
            Keys101,
            Keys108
        }

        private Keys _keys;

        public Keyboard(Keys keys)
        {
            _keys = keys;
        }

        public Keys KeyboardType
        {
            get => _keys;
            set => _keys = value;
        }

        public override string ToString()
        {
            return _keys switch
            {
                Keys.Keys101 => "101",
                Keys.Keys108 => "108",
                _ => throw new ArgumentException($"Invalid value _keys{_keys.ToString()}")
            };
        }
    }
}