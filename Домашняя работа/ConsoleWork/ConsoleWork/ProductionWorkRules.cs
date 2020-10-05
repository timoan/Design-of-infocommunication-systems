using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Правила работы для сотрудников производственного отдела, работающих согласно дневной норме.
    /// </summary>
    class ProductionWorkRules : WorkRules
    {
        /// <summary>
        /// Стандартный конструктор с заполнением всех полей класса.
        /// </summary>
        public ProductionWorkRules(string position): base(position)
        {
            ArrayList array = ProxyDatabase.MyProxyDatabase.selectWorkRulesFromDB(position);

            breakRegularity = (double)array[0];
            breakDuration = (double)array[1];
            dayStart = (int)array[2];
            eveningStart = (int)array[3];
            nightStart = (int)array[4];
        }
    }
}
