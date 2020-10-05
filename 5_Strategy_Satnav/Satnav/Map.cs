using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satnav
{
    class Map : NavigatorActions
    {
        public Map() { Title = "Показать карту"; }
        public override string ToString() { return Title; }
        public override void Action() { Console.WriteLine("...Карта..."); }
    }
}
