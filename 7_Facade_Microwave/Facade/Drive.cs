using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Drive
    {
        public event EventHandler driveevent;

        private string twist;

        public string Twist
        {
            get { return twist; }
            set
            {
                twist = value;

                if (driveevent != null) driveevent(this, new EventArgs());
            }
        }
        public Drive() { Twist = "исходная позиция"; }
        public void TurlLeft()
        {
            Twist = "Поверот налево";
        }
        public void TurlRight()
        {
            Twist = "Поверот направо";
        }
        public void Stop()
        {
            Twist = "Стоп";
        }
        public override string ToString()
        {
            string s = String.Format("Привод: {0}", Twist);
            return s;
        }
    }
}
