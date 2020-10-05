using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Adapter_ClimContr
{
    //Система климат-контроля, работающая с градусами Цельсия
    class ClimateControlSystem
    {
        static int lowNorm = 17;
        static int highNorm = 24;
        int t;

        public ClimateControlSystem() { }

        public void Check(ISensor temp)
        {
            t = temp.getTemp();
            Console.WriteLine("Сейчас {0} градусов.", t);
            if (t > highNorm)
            {
                Console.WriteLine("Понижаем температуру на {0} градусов...", t - highNorm);
            }
            else if (t < lowNorm)
            {
                Console.WriteLine("Повышаем температуру на {0} градусов...", lowNorm - t);
            }
            else
            {
                Console.WriteLine("Температура нормальная, составляет {0} градусов.", t);
            }
        }
    }
}
