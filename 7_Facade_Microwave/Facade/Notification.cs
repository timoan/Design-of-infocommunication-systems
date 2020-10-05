using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Notification
    {
        public event EventHandler notificationevent;

        private string mess;

        public string MessageFin
        {
            get { return mess; }
            set
            {
                mess = value;
                if (notificationevent != null)
                    notificationevent(this, new EventArgs());
            }
        }
        public void StartNotification()
        { MessageFin = "Операция началась"; }

        public void StopNotification() { MessageFin = "Операция завершена"; }

        public override string ToString()
        {
            string s = String.Format("Информация: {0}", MessageFin);
            return s;
        }
    }
}
