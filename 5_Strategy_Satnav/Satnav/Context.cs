using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satnav
{
    class Context
    {
        NavigatorActions nav;
        public Context(NavigatorActions nav) { this.nav = nav; }
        public void Action() { nav.Action(); }
        public void PrintAction() { Console.WriteLine(nav.ToString()); }
    }
}
