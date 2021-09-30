using System;

namespace WindowsUI
{
    public class Button
    {
        public event Action Click;

        public void OnClick()
        {
            Click?.Invoke();
        }
    }
}
