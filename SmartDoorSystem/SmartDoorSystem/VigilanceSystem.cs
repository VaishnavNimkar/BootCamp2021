using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoorSystem
{
    public class VigilanceSystem
    {
        SmartDoor _smartDoor;

        public VigilanceSystem(SmartDoor _doorRef)
        {
            _smartDoor = _doorRef;
            Action<string> _eventHadnlerAddress = new Action<string>(Notify);
            _smartDoor.OnAction += _eventHadnlerAddress;
        }

        public void Notify(string doorStatus)
        {

            Console.WriteLine("Door Status :{0}", doorStatus);
        }
    }
}
