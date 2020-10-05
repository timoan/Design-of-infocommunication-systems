using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Адаптер, позволяющий соединить систему считывания, работающую со строковым значением идентификатора,
    /// и систему учета времени, принимающую целые значения. Формирует цепочку обязанностей для обработки прохождения КПП.
    /// </summary>
    class AdapterHandler: IReadable
    {
        /// <summary>
        /// Обработчик обязанности "зафиксировать начало рабочего дня" для цепочки обязанностей "фиксирование прохождения".
        /// </summary>        
        Handler handlerIn;
        /// <summary>
        /// Обработчик обязанности "зафиксировать окончание рабочего дня" для цепочки обязанностей "фиксирование прохождения".
        /// </summary>
        Handler handlerOut;
        /// <summary>
        /// Инициализация обработчиков и формирование последовательности обработки запроса (создание цепочки).
        /// </summary>
        public AdapterHandler()
        {
            handlerIn = new HandlerIn();
            handlerOut = new HandlerOut();

            handlerOut.NextHandler = handlerIn;
        }
        /// <summary>
        /// Обработка прохождения пропускного пункта сотрудником.
        /// </summary>
        /// <param name="id">Идентификатор пользователя, считанный с карты</param>
        /// <returns>Корректность работы программы</returns>
        public bool fixGo(string id)
        {
            return handlerOut.fixGo(Convert.ToInt32(id));
        }
    }
}
