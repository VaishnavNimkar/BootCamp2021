using System;

namespace PubSub1
{
	public class SMSDeliverySystem
	{
        public void SendSms()
        {
            Console.WriteLine("Send SMS Observer");
        }
        public void Update(AppointmentStatus status)
        {
            SendSms();
        }
    }
}
