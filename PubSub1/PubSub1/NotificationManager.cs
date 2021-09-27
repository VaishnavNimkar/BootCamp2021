using System;

namespace PubSub1
{
	public class NotificationManager
	{
        Action<AppointmentStatus> observers;
        public void Register(Action<AppointmentStatus> observer)
        {
            observers += observer;
        }
        public void UnRegister(Action<AppointmentStatus> observer)
        {
            observers -= observer;
        }
        public void Notify(AppointmentStatus status)
        {
            Console.WriteLine(status);
            this.observers.Invoke(status);
        }
    }
}
