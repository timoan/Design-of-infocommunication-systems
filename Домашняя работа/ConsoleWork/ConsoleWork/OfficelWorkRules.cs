using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Правила работы для сотрудников офисного отдела, работающих согласно дневной норме.
    /// </summary>
    class OfficelWorkRules: WorkRules
    {
        /// <summary>
        /// Стандартный конструктор с заполнением всех полей класса.
        /// </summary>
        public OfficelWorkRules(string position): base(position)
        {
            ArrayList array = ProxyDatabase.MyProxyDatabase.selectWorkRulesFromDB(position);

            breakRegularity = (double)array[0];
            breakDuration = (double)array[1];
            workRate = (double)array[2];
        }

    }
}
