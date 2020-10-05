using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Adapter_ClimContr
{
    class AdapterSensor: ISensor
    {
        SensorF temp;
        public AdapterSensor(SensorF temp) { this.temp = temp; }

        public int getTemp()
        {
            return (temp.getTempF() - 32) * 5 / 9;
        }
    }
}
