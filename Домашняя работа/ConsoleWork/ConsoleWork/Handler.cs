using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Обработчик прохождения пропускного пункта.
    /// </summary>
    abstract class Handler
    {
        /// <summary>
        /// Система учета рабочего времени.
        /// </summary>
        protected TimeTrackingSystem system;
        /// <summary>
        /// Следующий объект цепочки обязанностей.
        /// </summary>
        protected Handler nextHandler;
        /// <summary>
        /// Следующий объект цепочки обязанностей.
        /// </summary>
        public Handler NextHandler
        {
            set 
            {
                nextHandler = value;
            }
        }

        /// <summary>
        /// Конструктор, определяющий систему учета рабочего времени.
        /// </summary>
        public Handler()
        {
            system = TimeTrackingSystem.System;
        }

        /// <summary>
        /// Обработка прохождения пропускного пункта.
        /// </summary>
        /// <param name="id">Уникальный идентификатор пользователя</param>
        /// <returns>Корректность работы программы</returns>
        abstract public bool fixGo(int id);        
    }
}
