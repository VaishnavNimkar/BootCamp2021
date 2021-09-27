using System;

namespace PubSub1
{
	public class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Hello World");
            EmailNotificationSystem _emailNS = new EmailNotificationSystem();
            SMSDeliverySystem _smsNs = new SMSDeliverySystem();

            Action<AppointmentStatus> _observer1 = new Action<AppointmentStatus>(_emailNS.Update);
            Action<AppointmentStatus> _observer2 = new Action<AppointmentStatus>(_smsNs.Update);

            NotificationManager _notificationManager = new NotificationManager();
            _notificationManager.Register(_observer1);
            _notificationManager.Register(_observer2);

            Appointment _appointment = new Appointment(_notificationManager);
            _appointment.Reserve();
            System.Threading.Tasks.Task.Delay(2000).Wait();
            _appointment.Confirm();
            System.Threading.Tasks.Task.Delay(2000).Wait();
            _appointment.Cancel();

            Console.ReadKey();

        }
	}
}
