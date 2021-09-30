using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoorSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SmartDoor door1 = new SmartDoor();
            VigilanceSystem _subscriber = new VigilanceSystem(door1);
            door1.Open();
            door1.Close();

            Console.ReadKey();
        }
    }
}
