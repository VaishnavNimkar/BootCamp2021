using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoorSystem
{
    public class SmartDoor
    {
        public void Open()
        {
            OnActionChanged("Open");
        }
        public void Close()
        {
            OnActionChanged("Close");
        }

        public event Action<string> OnAction = null;

        private void OnActionChanged(string status)
        {
            if (OnAction != null)
            {
                OnAction.Invoke(status);
            }
        }
    }
}
