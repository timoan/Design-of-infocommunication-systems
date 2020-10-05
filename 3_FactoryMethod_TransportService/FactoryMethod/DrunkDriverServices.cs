using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DrunkDriverServices: TransportService
    {
        public static double sale = 0.5;

        public DrunkDriverServices(string name, int sale) : base(name) { }

        public override double CostTransportation(double distance) { return distance * sale; }

        public override string ToString()
        {
            string s = String.Format("Фирма {0}, доставка со скидкой", Name);
            return s;
        }
    }
}
