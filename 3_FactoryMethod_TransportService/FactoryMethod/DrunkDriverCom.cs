using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DrunkDriverCom: TransportCompany
    {
        public DrunkDriverCom(string name) : base(name) { }

        public override TransportService Create(string n, int c) { return new DrunkDriverServices(Name, c); }
    }
}
