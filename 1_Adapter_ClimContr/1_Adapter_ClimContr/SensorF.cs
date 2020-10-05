using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Adapter_ClimContr
{
    //датчик температуры Фаренгейта
    class SensorF
    {
        Random F;
        public SensorF() 
        { 
            F = new Random(); 
        }
        public int getTempF()
        {
            return F.Next(-40, 100);
        }
    }
}

//Использование адаптера упрощает производить совместимость систем,
//делая процесс менее трудоемким и более читабельным. 