using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Абстрактная фабрика сотрудников предприятия.
    /// </summary>
    abstract class EmployeeFactory
    {
        /// <summary>
        /// Идентификатор сотрудника.
        /// </summary>
        protected int id;
        /// <summary>
        /// Идентификатор сотрудника.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
        }
        /// <summary>
        /// Личная смарт-карта сотрудника с его данными.
        /// </summary>
        protected Card card;
        /// <summary>
        /// Текущий сеанс работы сотрудника предприятия.
        /// </summary>
        protected Work work;
        /// <summary>
        /// Правила работы сотрудника, необходимые для расчета рабочего сеанса.
        /// </summary>
        protected WorkRules workRules;

        /// <summary>
        /// Конструктор, заполняющий поля класса с помощью использования фабричный методов.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        public EmployeeFactory(int id)
        {
            this.id = id;
            card = createCard(id);
            work = createWork();
        }
        /// <summary>
        /// Производит завершение рабочего сеанса, фиксирую время окончания и производя рассчет требуемых параметров.
        /// </summary>
        /// <returns></returns>
        public bool endWork()
        {
            work.TimeLeaving = DateTime.Now;

            workRules = createWorkRules(card.Position);

            if (calculatedWork())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Сохранение данных о сторуднике.
        /// </summary>
        /// <returns>Корректность операции</returns>
        public bool saveWork()
        {
            return work.setWorkDB(id);
        }

        /// <summary>
        /// Рассчет общих параметров текущего рабочего сеанса.
        /// </summary>
        /// <returns>Корректность операции</returns>
        virtual protected bool calculatedWork()
        {
            return work.calculateGeneralTime(workRules.BreakRegularity, workRules.BreakDuration);
        }

        /// <summary>
        /// Фабричный метод для создания карты сотрудника.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Карта сотрудника</returns>
        abstract protected Card createCard(int id);
        /// <summary>
        /// Фабричный метод для создания рабочей сессии сотрудника.
        /// </summary>
        /// <returns>Рабочая сессия</returns>
        abstract protected Work createWork();
        /// <summary>
        /// Фабричный метод для создания правил работы сотрудника.
        /// </summary>
        /// <returns>Правила работы</returns>
        abstract protected WorkRules createWorkRules(string position);

    }
}
