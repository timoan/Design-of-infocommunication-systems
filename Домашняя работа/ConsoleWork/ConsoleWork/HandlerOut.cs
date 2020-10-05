using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Обработчик прохождения пропускного пункта на выход.
    /// </summary>
    class HandlerOut: Handler
    {
        /// <summary>
        /// Конструктор, определяющий систему учета рабочего времени.
        /// </summary>
        public HandlerOut() : base()
        { }

        /// <summary>
        /// Обработка прохождения пропускного пункта при уходе с работы.
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <returns>Корректность обработки данных.</returns>
        public override bool fixGo(int id)
        {
            if (system.checkIsEmployee(id))
            {
                if(system.updateEmployee(id))
                {
                    if(system.saveEmployee(id))
                    {
                        if(system.deleteEmployee(id))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                 return nextHandler.fixGo(id);
            }
        }
    }
}
