using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    class HandlerIn: Handler
    {
        /// <summary>
        /// Конструктор, определяющий систему учета рабочего времени.
        /// </summary>
        public HandlerIn() : base()
        { }

        /// <summary>
        /// Обработка прохождения пропускного пункта при приходе на работу.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <returns>Корректность обработки данных</returns>
        public override bool fixGo(int id)
        {
            if (ProxyDatabase.MyProxyDatabase.isEmployeeInDB(id))
            {
                if(system.addEmployee(id))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
