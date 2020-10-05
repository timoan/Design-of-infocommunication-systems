using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Cook
    {
        private Drive _drive;
        private Power _power;
        private Notification _notification;
        public Cook(Drive drive, Power power, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
        }
        public void Defrost()
        {
            Console.WriteLine("С какой мощностью готовить еду?");
            _power.MicrowavePower = int.Parse(Console.ReadLine());
            _notification.StartNotification();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlRight();
            _drive.TurlRight(); _drive.Stop();
            _notification.StopNotification();
        }
    }
}
