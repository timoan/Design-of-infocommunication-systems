using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Абстрактный класс карт сотрудников предприятия.
    /// </summary>
    abstract class Card
    {
        /// <summary>
        /// Имя сотрудника.
        /// </summary>
        protected string name;
        /// <summary>
        /// Фамилия сотрудника.
        /// </summary>
        protected string surname;
        /// <summary>
        /// Должность сотрудника.
        /// </summary>
        protected string position;
        /// <summary>
        /// Должность сотрудника.
        /// </summary>
        public string Position
        {
            get
            {
                return position;
            }
        }

        /// <summary>
        /// Конструктор, заполняющий поля класса из БД согласно идентификатору сотрудника.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        public Card(int id)
        {
            ArrayList array = ProxyDatabase.MyProxyDatabase.selectCardFromDB(id);
            name = (string)array[0];
            surname = (string)array[1];  
        }
    }

}
