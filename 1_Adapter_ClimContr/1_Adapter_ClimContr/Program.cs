using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Adapter_ClimContr
{
    class Program
    {
        static void Main(string[] args)
        {
            SensorF F = new SensorF();
            ClimateControlSystem system = new ClimateControlSystem();
            ISensor temp = new AdapterSensor(F);
            system.Check(temp);
        }
    }
}
