namespace PubSub1
{
	public class Appointment
	{
        AppointmentStatus status;
        NotificationManager _notifyManager;
        public Appointment(NotificationManager notificationManager)
        {
            this._notifyManager = notificationManager;
        }
        public void Confirm()
        {
            this.status = AppointmentStatus.CONFIRMED;
            this.Notify();
        }
        public void Cancel()
        {
            this.status = AppointmentStatus.CANCELLED;
            this.Notify();
        }

        public void Reserve()
        {

            this.status = AppointmentStatus.PENDING;
            this.Notify();
        }
        void Notify()
        {
            _notifyManager.Notify(this.status);
        }

    }
}
