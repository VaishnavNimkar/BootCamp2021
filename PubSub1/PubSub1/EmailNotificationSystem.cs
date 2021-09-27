using System;

namespace PubSub1
{
	public class EmailNotificationSystem
	{
        public void SendEmail()
        {
            Console.WriteLine("Send Enail Observer");
        }
        public void Update(AppointmentStatus status)
        {
            SendEmail();
        }
    }
}
